using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Admin
{
    
    public partial class viewTrainAdmin : Form
    {
        string conStr = UserFunctions.connectionString;
        public viewTrainAdmin()
        {
            InitializeComponent();
        }

        private void searchtrainButton_Click(object sender, EventArgs e)
        {
            string trainId = searchIdBox.Text.Trim();

            if (string.IsNullOrEmpty(trainId))
            {
                MessageBox.Show("Please enter a train ID to search.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open();

                // Search by train_id only
                string sql = "SELECT * FROM TRAINSCHEDULE WHERE train_id = :trainId";
                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    cmd.Parameters.Add(new OracleParameter(":trainId", trainId));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Train schedule found, populate text boxes
                            trainNamebox.Text = reader.GetString(0);  // train_name
                            trainDestinationBox.Text = reader.GetString(1);  // destination
                            trainArrivalBox.Text = reader.GetString(2);   // arrival
                            traintypeBox.Text = reader.GetString(3);   // type
                            trainEndTimeBox.Text = reader.GetString(4);  // dest_time
                            trainStartTimeBox.Text = reader.GetString(5); // arrival_time
                            trainAnnoucementBox.Text = reader.GetString(6); // announcements

                            
                        }
                        else
                        {
                            // Train schedule not found, clear text boxes
                            trainNamebox.Text = "";
                            trainDestinationBox.Text = "";
                            traintypeBox.Text = "";
                            trainArrivalBox.Text = "";
                            trainEndTimeBox.Text = "";
                            trainStartTimeBox.Text = "";
                            trainAnnoucementBox.Text = "";

                            MessageBox.Show("No train schedule found for the entered train ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
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

        private void trainImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the file dialog properties
            openFileDialog1.Title = "Select Image";

            // Add "All Files" filter
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0; // Set "All Files" as default filter

            // Add image filters (optional)
            openFileDialog1.Filter += "|Image Files (.bmp;.jpg;.jpeg,.png)|.BMP;.JPG;.JPEG;.PNG";

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
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
