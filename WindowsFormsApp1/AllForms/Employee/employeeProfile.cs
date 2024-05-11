using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class employeeProfile : Form
    {
        string conStr = UserFunctions.connectionString;
        //private TextBox adminNameTextBox;
        //private TextBox emailTextBox;
        //private TextBox passwordTextBox;
        private string emailFromEmployee = "umair@employee.com";
        public employeeProfile()
        {
            InitializeComponent();
        }
        public employeeProfile(string _email)
        {
            InitializeComponent();
            emailFromEmployee = _email;
        }

        private void employeeProfile_Load(object sender, EventArgs e)
        {
            string sql = "SELECT E_USERNAME, E_PASSWORD, E_About FROM EMPLOYEE WHERE E_EMAIL_ID = :Email";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromEmployee;

                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string eName = reader["E_USERNAME"].ToString();
                            string ePassword = reader["E_PASSWORD"].ToString();
                            string eAbout = reader["E_ABOUT"].ToString();
                           
                            empName.Text = eName;
                            empPassword.Text = ePassword;
                            empEmail.Text = emailFromEmployee;
                            empAbout.Text = eAbout;
                        }
                        else
                        {
                            MessageBox.Show("Admin information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving admin information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dashboard.getDashboard().Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (empPassword.PasswordChar == '*')
            {
                empPassword.PasswordChar = (char)0;
                pictureBox1.Image = Properties.Resources.icons8_eye_25;
            }
            else
            {
                empPassword.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.icons8_eye_25__1_;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string e_username = empName.Text;
            string e_email_id = empEmail.Text;
            string e_password = empPassword.Text;
            string e_about = empAbout.Text;

            string sql = "UPDATE EMPLOYEE SET E_USERNAME = :Username, E_EMAIL_ID = :Email, E_PASSWORD = :Password, E_ABOUT = :About WHERE E_EMAIL_ID = :OldEmail";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Username", OracleDbType.Varchar2).Value = e_username;
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = e_email_id;
                cmd.Parameters.Add(":Password", OracleDbType.Varchar2).Value = e_password;
                cmd.Parameters.Add(":About", OracleDbType.Varchar2).Value = e_about;
                cmd.Parameters.Add(":OldEmail", OracleDbType.Varchar2).Value = emailFromEmployee;

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee information updated successfully.");
                        // Update the emailFromEmployee if the email is changed
                        emailFromEmployee = e_email_id;
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the given email.");
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while updating employee information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
