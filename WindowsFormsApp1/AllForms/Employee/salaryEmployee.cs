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

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class salaryEmployee : Form
    {
        string conStr = UserFunctions.connectionString;
        public salaryEmployee()
        {
            InitializeComponent();
        }

        private void salaryEmployee_Load(object sender, EventArgs e)
        {
            string emailFromEmployee = "umair@employee.com";
            string sql = "SELECT CONCAT('$', E_SALARY) FROM employee WHERE E_EMAIL_ID = :Email";

            // Establish a connection to the database and execute the query
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromEmployee;

                try
                {
                    connection.Open();
                    object salary = cmd.ExecuteScalar();
                    if (salary != null)
                    {
                        // Display the salary in textBox1
                        textBox1.Text = salary.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Salary not found for the employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving salary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
