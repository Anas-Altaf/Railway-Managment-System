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

namespace WindowsFormsApp1
{
    public partial class LoginEmployee : Form
    {
        //Establishing Oracle Connection
        string conStr = UserFunctions.connectionString;
        public LoginEmployee()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UserFunctions.Apply_Panel1_Transparency(panel1);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dashboard.getDashboard().Show();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(conStr);
                connection.Open(); // Open the connection

                OracleCommand userId = connection.CreateCommand();
                userId.CommandText = "SELECT e_email_id FROM EMPLOYEE WHERE e_email_id = :email AND e_password = :password";
                userId.Parameters.Add(new OracleParameter(":email", email));
                userId.Parameters.Add(new OracleParameter(":password", password));
                userId.CommandType = CommandType.Text;

                OracleDataReader userDR = userId.ExecuteReader();

                if (userDR.Read())
                {
                    // Login successful!
                    string e_email_id = userDR.GetString(0);

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.Close();
                    AdminDashboard adminDash = new AdminDashboard();
                    //Going to show admin dashboard
                    adminDash.ShowDialog();
                }
                else
                {
                    // Login failed (invalid email or password)
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                userDR.Close(); // Manually close DataReader
                connection.Close();
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
                }
            }
        }
    }
}
