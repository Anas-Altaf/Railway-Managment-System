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
            string sql = "SELECT * FROM TrainSchedule"; // Select all columns

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open();

                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        trainScheduleData.Clear(); // Clear existing data before populating

                        // Add columns to DataTable based on reader metadata (optional, already done in constructor)
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            trainScheduleData.Columns.Add(reader.GetName(i));
                        }

                        // Read data rows and add them to DataTable
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
            catch (Exception ex) // Catch more general exceptions
            {
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

                trainIdBox.Text = selectedRow["Train_Id"].ToString(); // Assuming a "TrainId" column
                trainNamebox.Text = selectedRow["Train_Name"].ToString(); // Assuming a "TrainName" column
                trainDestinationBox.Text = selectedRow["Destination"].ToString(); // Assuming a "Destination" column
                traintypeBox.Text = selectedRow["Type"].ToString(); // Assuming a "Type" column
                trainArrivalBox.Text = selectedRow["Arrival"].ToString(); // Assuming an "Arrival" column
                trainEndTimeBox.Text = selectedRow["Dest_Time"].ToString(); // Assuming a "DestTime" column
                trainStartTimeBox.Text = selectedRow["Arrival_Time"].ToString(); // Assuming an "ArrivalTime" column
                trainAnnoucementBox.Text = selectedRow["Announcements"].ToString(); // Assuming an "Announcements" column
                // Set train image (assuming an "Image" column holding image data or path)
                if (selectedRow["train_picture"] != null)
                {
                    // Option 1: Assuming "Image" column holds the image data (e.g., byte[])
                    if (selectedRow["train_picture"] is byte[])
                    {
                        trainImageBox.Image = new Bitmap(new MemoryStream((byte[])selectedRow["train_picture"]));
                    }

                    // Option 2: Assuming "Image" column holds a path to the image file
                    else if (selectedRow["train_picture"] is string)
                    {
                        try
                        {
                            trainImageBox.Image = Image.FromFile((string)selectedRow["train_picture"]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Handle potential image loading errors (e.g., file not found)
                        }
                    }
                    else
                    {
                        // Handle unexpected data type in "Image" column
                    }
                }
                else
                {
                    // Set a default image or clear the existing image if no image available
                    trainImageBox.Image = null; // Or set a default image using trainImageBox.Image = Properties.Resources.DefaultTrainImage;
                }
            }
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            // Validate input (except Announcement and Image)
            if (string.IsNullOrEmpty(trainNamebox.Text) ||
                string.IsNullOrEmpty(trainDestinationBox.Text) ||
                string.IsNullOrEmpty(traintypeBox.Text) ||
                string.IsNullOrEmpty(trainArrivalBox.Text) ||
                string.IsNullOrEmpty(trainStartTimeBox.Text) ||
                string.IsNullOrEmpty(trainEndTimeBox.Text))
            {
                MessageBox.Show("Please fill in all mandatory fields (except Announcement and Image).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the function if any mandatory field is empty
            }

            // Prepare SQL statement
            string sql = "INSERT INTO TrainSchedule (Train_Id, Train_Name, Destination, Type, Arrival, Arrival_Time, Dest_Time, Announcements, train_picture) " +
                         "VALUES (:train_id, :TrainName, :Destination, :Type, :Arrival, :ArrivalTime, :DestTime, :Announcements, :Image)";

            // Create Oracle command
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                // Add parameters
                cmd.Parameters.Add(":train_id", OracleDbType.Varchar2).Value = trainIdBox.Text;
                cmd.Parameters.Add(":TrainName", OracleDbType.Varchar2).Value = trainNamebox.Text;
                cmd.Parameters.Add(":Destination", OracleDbType.Varchar2).Value = trainDestinationBox.Text;
                cmd.Parameters.Add(":Type", OracleDbType.Varchar2).Value = traintypeBox.Text;
                cmd.Parameters.Add(":Arrival", OracleDbType.Varchar2).Value = trainArrivalBox.Text;
                cmd.Parameters.Add(":ArrivalTime", OracleDbType.Varchar2).Value = trainStartTimeBox.Text;
                cmd.Parameters.Add(":DestTime", OracleDbType.Varchar2).Value = trainEndTimeBox.Text;
                cmd.Parameters.Add(":Announcements", OracleDbType.Varchar2).Value = trainAnnoucementBox.Text;

                // Handle image (optional)
                if (trainImageBox.Image != null)
                {
                    try
                    {
                        // Convert image to byte array
                        using (MemoryStream ms = new MemoryStream())
                        {
                            trainImageBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Adjust format as needed
                            byte[] imageByteArray = ms.ToArray();
                            cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = imageByteArray;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error converting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the function if image conversion fails
                    }
                }
                else
                {
                    cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = DBNull.Value; // Set null for no image
                }

                // Open connection and execute command
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateDataGridView(); // Call the method to refresh DataGridView

                    // Clear input fields and image
                    trainNamebox.Text = "";
                    trainDestinationBox.Text = "";
                    traintypeBox.Text = "";
                    trainArrivalBox.Text = "";
                    trainEndTimeBox.Text = "";
                    trainStartTimeBox.Text = "";
                    trainAnnoucementBox.Text = "";
                    trainImageBox.Image = null; // Clear image (optional)
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error adding train schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void trainImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the file dialog properties
            openFileDialog1.Title = "Select Image";
            openFileDialog1.Filter = "All Files (*.*)|*.*|Image Files (.bmp;.jpg;.jpeg,.png)|.BMP;.JPG;.JPEG;.PNG";
            openFileDialog1.FilterIndex = 0; // Set "All Files" as default filter

            // Show the file dialog
            DialogResult result = openFileDialog1.ShowDialog();

            // Check if the user selected a file
            if (result == DialogResult.OK)
            {
                try
                {
                    // Get the selected file name and display in PictureBox
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
            
            // Ensure that a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataRowView selectedRowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRowView == null)
            {
                MessageBox.Show("Failed to get selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the DataRow associated with the selected row
            DataRow selectedRow = selectedRowView.Row;

            // Prepare SQL statement for updating the row
            string sql = "UPDATE TrainSchedule SET Train_Name = :TrainName, Destination = :Destination, Type = :Type, Arrival = :Arrival, " +
                         "Arrival_Time = :ArrivalTime, Dest_Time = :DestTime, Announcements = :Announcements, train_picture = :Image " +
                         "WHERE Train_Id = :TrainId";

            // Create OracleCommand
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                // Add parameters
                cmd.Parameters.Add(":TrainName", OracleDbType.Varchar2).Value = trainNamebox.Text;
                cmd.Parameters.Add(":Destination", OracleDbType.Varchar2).Value = trainDestinationBox.Text;
                cmd.Parameters.Add(":Type", OracleDbType.Varchar2).Value = traintypeBox.Text;
                cmd.Parameters.Add(":Arrival", OracleDbType.Varchar2).Value = trainArrivalBox.Text;
                cmd.Parameters.Add(":ArrivalTime", OracleDbType.Varchar2).Value = trainStartTimeBox.Text;
                cmd.Parameters.Add(":DestTime", OracleDbType.Varchar2).Value = trainEndTimeBox.Text;
                cmd.Parameters.Add(":Announcements", OracleDbType.Varchar2).Value = trainAnnoucementBox.Text;
                cmd.Parameters.Add(":TrainId", OracleDbType.Varchar2).Value = selectedRow["Train_Id"];

                // Handle image (optional)
                if (trainImageBox.Image != null)
                {
                    try
                    {
                        // Convert image to byte array
                        using (MemoryStream ms = new MemoryStream())
                        {
                            trainImageBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Adjust format as needed
                            byte[] imageByteArray = ms.ToArray();
                            cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = imageByteArray;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error converting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the function if image conversion fails
                    }
                }
                else
                {
                    cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = DBNull.Value; // Set null for no image
                }

                // Open connection and execute command
                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train schedule updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populateDataGridView(); // Refresh DataGridView to reflect changes
                    }
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
            // Ensure that a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataRowView selectedRowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            if (selectedRowView == null)
            {
                MessageBox.Show("Failed to get selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the DataRow associated with the selected row
            DataRow selectedRow = selectedRowView.Row;

            // Prepare SQL statement for deleting the row
            string sql = "DELETE FROM TrainSchedule WHERE Train_Id = :TrainId";

            // Create OracleCommand
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                // Add parameter for TrainId
                cmd.Parameters.Add(":TrainId", OracleDbType.Varchar2).Value = selectedRow["Train_Id"];

                // Open connection and execute command
                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train schedule deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        populateDataGridView(); // Refresh DataGridView to reflect changes
                    }
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
            // Clear text of all textboxes
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
