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
    public partial class viewTaskEmployee : Form
    {
        string conStr = UserFunctions.connectionString;
        public viewTaskEmployee()
        {
            InitializeComponent();
        }

        private void btnCompletedTasks_Click(object sender, EventArgs e)
        {
            listBoxCompleteTasks.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBoxCompleteTasks.Items.Add(s);
        }


        private void btnTodoTasks_Click(object sender, EventArgs e)
        {
            listBoxTodoTasks.Items.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    listBoxTodoTasks.Items.Add(checkedListBox1.Items[i]);
                }
            }
        }

        private void viewTaskEmployee_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            string emailFromEmployee = "umair@employee.com";
            string sql = "SELECT e_task FROM employee_task WHERE e_email_id = :Email";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Email", OracleDbType.Varchar2).Value = emailFromEmployee;

                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string task = reader["e_task"].ToString();
                            checkedListBox1.Items.Add(task);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
