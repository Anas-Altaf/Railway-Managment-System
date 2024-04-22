//For Oracle Connectivity
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.EntityFramework;
//Other
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1
{
    public partial class LoginAdmin : Form
    {
        //Establishing Oracle Connection
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = umair; PASSWORD = umair";
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int opacity = 85; // 50% of 255 (maximum alpha value)

            // Set the background color of the panel with adjusted opacity
            panel1.BackColor = Color.FromArgb(opacity, panel1.BackColor);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            statusBarTextBox.Text = $"Email: {email}, Password: {password}";

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open(); // Open the connection
                statusBarTextBox.Text = $"1- Connection Opened";

                OracleCommand userId = connection.CreateCommand();
                userId.CommandText = "SELECT a_id FROM ADMINISTRATOR WHERE a_id = :email AND a_password = :password";
                userId.Parameters.Add(new OracleParameter(":email", email));
                userId.Parameters.Add(new OracleParameter(":password", password));
                userId.CommandType = CommandType.Text;

                statusBarTextBox.Text = $"2 - Query Executed !";
                OracleDataReader userDR = userId.ExecuteReader();

                if (userDR.Read())
                {
                    // Login successful!
                    string a_id = userDR.GetString(0);
                    statusBarTextBox.Text = $"5- a_id: {a_id}, email: {email}";
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, proceed to the main application window here
                }
                else
                {
                    // Login failed (invalid email or password)
                    statusBarTextBox.Text = $"5- Invalid email or password";
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                userDR.Close(); // Manually close DataReader
            }
            catch (OracleException ex)
            {
                // Handle database-related exceptions gracefully
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Catch more general exceptions
            {
                // Handle unexpected errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed regardless of success or failure
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    statusBarTextBox.Text = $"6- Connection Closed";
                }
            }
        }



        private void backButton_Click(object sender, EventArgs e)
        { 
            Dashboard dashboardObj = new Dashboard();
            dashboardObj.Show();
            this.Close();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}