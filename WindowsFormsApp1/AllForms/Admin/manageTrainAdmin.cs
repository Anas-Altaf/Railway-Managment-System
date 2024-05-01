using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Admin
{
    public partial class manageTrainAdmin : Form
    {
        private DataTable trainScheduleData = new DataTable();
        string conStr = UserFunctions.connectionString;
        public manageTrainAdmin()
        {
            InitializeComponent();
            populateDataGridView();
        }


        private void populateDataGridView()
        {
            string sql = "SELECT * FROM TrainSchedule"; 
            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open();

                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        trainScheduleData.Clear(); 
                                                for (int i = 0; i < reader.FieldCount; i++)
                        {
                            trainScheduleData.Columns.Add(reader.GetName(i));
                        }

                                                while (reader.Read())
                        {
                            DataRow row = trainScheduleData.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
                            trainScheduleData.Rows.Add(row);
                        }
                    }
                }
                dataGridView1.DataSource = trainScheduleData;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)             {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView selectedRowView = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (selectedRowView != null)
            {
                DataRow selectedRow = selectedRowView.Row;

                trainIdBox.Text = selectedRow["Train_Id"].ToString();                 trainNamebox.Text = selectedRow["Train_Name"].ToString();                 trainDestinationBox.Text = selectedRow["Destination"].ToString();                 traintypeBox.Text = selectedRow["Type"].ToString();                 trainArrivalBox.Text = selectedRow["Arrival"].ToString();                 trainEndTimeBox.Text = selectedRow["Dest_Time"].ToString();                 trainStartTimeBox.Text = selectedRow["Arrival_Time"].ToString();                 trainAnnoucementBox.Text = selectedRow["Announcements"].ToString();                                 if (selectedRow["train_picture"] != null)
                {
                                        if (selectedRow["train_picture"] is byte[])
                    {
                        trainImageBox.Image = new Bitmap(new MemoryStream((byte[])selectedRow["train_picture"]));
                    }

                                        else if (selectedRow["train_picture"] is string)
                    {
                        try
                        {
                            trainImageBox.Image = Image.FromFile((string)selectedRow["train_picture"]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                    }
                    else
                    {
                                            }
                }
                else
                {
                                        trainImageBox.Image = null;                 }
            }
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
                        if (string.IsNullOrEmpty(trainNamebox.Text) ||
                string.IsNullOrEmpty(trainDestinationBox.Text) ||
                string.IsNullOrEmpty(traintypeBox.Text) ||
                string.IsNullOrEmpty(trainArrivalBox.Text) ||
                string.IsNullOrEmpty(trainStartTimeBox.Text) ||
                string.IsNullOrEmpty(trainEndTimeBox.Text))
            {
                MessageBox.Show("Please fill in all mandatory fields (except Announcement and Image).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;             }

                        string sql = "INSERT INTO TrainSchedule (Train_Id, Train_Name, Destination, Type, Arrival, Arrival_Time, Dest_Time, Announcements, train_picture) " +
                         "VALUES (:train_id, :TrainName, :Destination, :Type, :Arrival, :ArrivalTime, :DestTime, :Announcements, :Image)";

                        using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                                cmd.Parameters.Add(":train_id", OracleDbType.Varchar2).Value = trainIdBox.Text;
                cmd.Parameters.Add(":TrainName", OracleDbType.Varchar2).Value = trainNamebox.Text;
                cmd.Parameters.Add(":Destination", OracleDbType.Varchar2).Value = trainDestinationBox.Text;
                cmd.Parameters.Add(":Type", OracleDbType.Varchar2).Value = traintypeBox.Text;
                cmd.Parameters.Add(":Arrival", OracleDbType.Varchar2).Value = trainArrivalBox.Text;
                cmd.Parameters.Add(":ArrivalTime", OracleDbType.Varchar2).Value = trainStartTimeBox.Text;
                cmd.Parameters.Add(":DestTime", OracleDbType.Varchar2).Value = trainEndTimeBox.Text;
                cmd.Parameters.Add(":Announcements", OracleDbType.Varchar2).Value = trainAnnoucementBox.Text;

                                if (trainImageBox.Image != null)
                {
                    try
                    {
                                                using (MemoryStream ms = new MemoryStream())
                        {
                            trainImageBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);                             byte[] imageByteArray = ms.ToArray();
                            cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = imageByteArray;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error converting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;                     }
                }
                else
                {
                    cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = DBNull.Value;                 }

                                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateDataGridView(); 
                                        trainNamebox.Text = "";
                    trainDestinationBox.Text = "";
                    traintypeBox.Text = "";
                    trainArrivalBox.Text = "";
                    trainEndTimeBox.Text = "";
                    trainStartTimeBox.Text = "";
                    trainAnnoucementBox.Text = "";
                    trainImageBox.Image = null;                 }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error adding train schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void trainImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

                        openFileDialog1.Title = "Select Image";
            openFileDialog1.Filter = "All Files (*.*)|*.*|Image Files (.bmp;.jpg;.jpeg,.png)|.BMP;.JPG;.JPEG;.PNG";
            openFileDialog1.FilterIndex = 0; 
                        DialogResult result = openFileDialog1.ShowDialog();

                        if (result == DialogResult.OK)
            {
                try
                {
                                        string imagePath = openFileDialog1.FileName;
                    trainImageBox.Image = Image.FromFile(imagePath);
                    trainImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
                        if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                        DataRowView selectedRowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRowView == null)
            {
                MessageBox.Show("Failed to get selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                        DataRow selectedRow = selectedRowView.Row;

                        string sql = "UPDATE TrainSchedule SET Train_Name = :TrainName, Destination = :Destination, Type = :Type, Arrival = :Arrival, " +
                         "Arrival_Time = :ArrivalTime, Dest_Time = :DestTime, Announcements = :Announcements, train_picture = :Image " +
                         "WHERE Train_Id = :TrainId";

                        using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                                cmd.Parameters.Add(":TrainName", OracleDbType.Varchar2).Value = trainNamebox.Text;
                cmd.Parameters.Add(":Destination", OracleDbType.Varchar2).Value = trainDestinationBox.Text;
                cmd.Parameters.Add(":Type", OracleDbType.Varchar2).Value = traintypeBox.Text;
                cmd.Parameters.Add(":Arrival", OracleDbType.Varchar2).Value = trainArrivalBox.Text;
                cmd.Parameters.Add(":ArrivalTime", OracleDbType.Varchar2).Value = trainStartTimeBox.Text;
                cmd.Parameters.Add(":DestTime", OracleDbType.Varchar2).Value = trainEndTimeBox.Text;
                cmd.Parameters.Add(":Announcements", OracleDbType.Varchar2).Value = trainAnnoucementBox.Text;
                cmd.Parameters.Add(":TrainId", OracleDbType.Varchar2).Value = selectedRow["Train_Id"];

                                if (trainImageBox.Image != null)
                {
                    try
                    {
                                                using (MemoryStream ms = new MemoryStream())
                        {
                            trainImageBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);                             byte[] imageByteArray = ms.ToArray();
                            cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = imageByteArray;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error converting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;                     }
                }
                else
                {
                    cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = DBNull.Value;                 }

                                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train schedule updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populateDataGridView();                     }
                    else
                    {
                        MessageBox.Show("No rows were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error updating train schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
                        if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                        DataRowView selectedRowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRowView == null)
            {
                MessageBox.Show("Failed to get selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                        DataRow selectedRow = selectedRowView.Row;

                        string sql = "DELETE FROM TrainSchedule WHERE Train_Id = :TrainId";

                        using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                                cmd.Parameters.Add(":TrainId", OracleDbType.Varchar2).Value = selectedRow["Train_Id"];

                                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train schedule deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populateDataGridView();                     }
                    else
                    {
                        MessageBox.Show("No rows were deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error deleting train schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
                        trainIdBox.Text = "";
            trainNamebox.Text = "";
            trainDestinationBox.Text = "";
            traintypeBox.Text = "";
            trainArrivalBox.Text = "";
            trainStartTimeBox.Text = "";
            trainEndTimeBox.Text = "";
            trainAnnoucementBox.Text = "";
        }
    }
}
