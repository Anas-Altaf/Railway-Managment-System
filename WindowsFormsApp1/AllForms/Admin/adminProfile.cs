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

    public partial class adminProfile : Form
    {
        string conStr = UserFunctions.connectionString;
        private TextBox adminNameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private string emailFromAdmin = "umair@rmsdb.com";
        public adminProfile()
        {
            InitializeComponent();
        }
        public adminProfile(string _email)
        {
            InitializeComponent();
            emailFromAdmin =_email;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dashboard.getDashboard().Show();
            }
        }

        private void adminProfile_Load(object sender, EventArgs e)
        {
            string sql = "SELECT A_NAME, A_About FROM administrator WHERE A_EMAIL_ID = :Email";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromAdmin;

                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string aName = reader["A_NAME"].ToString();
                            string aAbout = reader["A_About"].ToString();

                            // Display retrieved information in textboxes
                            adminName.Text = aName;
                            adminEmail.Text = emailFromAdmin;
                            adminAbout.Text = aAbout;
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
    }
}
