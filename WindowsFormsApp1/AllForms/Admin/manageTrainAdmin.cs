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

        private void button15_Click(object sender, EventArgs e)
        {
            // Validate input (except Announcement and Image)
            if (string.IsNullOrEmpty(trainIdBox.Text) ||
                string.IsNullOrEmpty(trainNamebox.Text) ||
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
            string sql = "INSERT INTO TrainSchedule ( Train_Name, Destination, Type, Arrival, Arrival_Time, Dest_Time, Announcements, Train_Id, train_picture) " +
                         "VALUES (:TrainName, :Destination, :Type, :Arrival, :ArrivalTime, :DestTime, :Announcements, :TrainId, :Image)";

            // Create Oracle command
            using (OracleCommand cmd = new OracleCommand(sql, new OracleConnection(conStr)))
            {
                // Add parameters
                cmd.Parameters.Add(":TrainId", OracleDbType.Decimal).Value = Convert.ToDecimal(trainIdBox.Text);
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
                            cmd.Parameters.Add(":Image", OracleDbType.Blob);
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
                    cmd.Parameters.Add(":Image", OracleDbType.Blob).Value = null; // Set null for no image
                }

                // Open connection and execute command
                try
                {
                    using (OracleConnection connection = new OracleConnection(conStr))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Train schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        trainIdBox.Text =
                        trainDestinationBox.Text = "";
                        traintypeBox.Text = "";
                        trainArrivalBox.Text = "";
                        trainEndTimeBox.Text = "";
                        trainStartTimeBox.Text = "";
                        trainAnnoucementBox.Text = "";

                        trainImageBox.Image = null; // Clear image (optional)
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Error adding train schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
