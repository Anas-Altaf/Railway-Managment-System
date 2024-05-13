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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class salaryEmployee : Form
    {
        string conStr = UserFunctions.connectionString;
        string _email = "umair@employee.com";
        public salaryEmployee()
        {
            InitializeComponent();
        }
        public salaryEmployee(string email)
        {
            _email = email;
            InitializeComponent();
        }


        private void salaryEmployee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT CONCAT('$', E_SALARY) FROM Salary WHERE E_EMAIL_ID = :Email";

            // Establish a connection to the database and execute the query
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = _email;

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

            //Salary table loading
            

                dataGridView1.Rows.Clear();
                 sql = "SELECT e_salary_id, e_salary, e_month, e_bonus FROM SALARY where e_email_id =:email";
                using (OracleConnection connection = new OracleConnection(conStr))
                using (OracleCommand cmd = new OracleCommand(sql, connection))
                {
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = _email;
                    try
                    {
                        connection.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string salaryId = reader["e_salary_id"].ToString().Trim();
                                string eSalary = reader["e_salary"].ToString().Trim();
                                string eMonth = reader["e_month"].ToString().Trim();
                                string eBonus = reader["e_bonus"].ToString().Trim();
                                dataGridView1.Rows.Add(salaryId, eSalary, eBonus, eMonth);
                            }
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }
    }
}
