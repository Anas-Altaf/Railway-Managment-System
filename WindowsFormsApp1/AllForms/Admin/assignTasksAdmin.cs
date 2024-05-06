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
    public partial class assignTasksAdmin : Form
    {
        public assignTasksAdmin()
        {
            InitializeComponent();
        }

        private void assignTasks_click(object sender, EventArgs e)
        {
            string query = "SELECT e_id, task FROM Employee WHERE task_status = 'assigned'";

            string conStr = UserFunctions.connectionString;

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        if (dataTable.Rows.Count > 0)
                        {
                            string assignedTasks = "";
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string eId = row["e_id"].ToString();
                                string task = row["task"].ToString();
                                assignedTasks += $"Employee ID: {eId}, Task: {task}\n";
                            }

                            textBox3.Text = assignedTasks;
                        }
                        else
                        {
                            textBox3.Text = "No tasks are currently assigned.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving assigned tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void completeTasks_click(object sender, EventArgs e)
        {
            textBox3.Text = "";

            string query = "SELECT e_id, task FROM Employee WHERE task_status = 'completed'";

            string conStr = UserFunctions.connectionString;

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        if (dataTable.Rows.Count > 0)
                        {
                            string completedTasks = "";
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string eId = row["e_id"].ToString();
                                string task = row["task"].ToString();
                                completedTasks += $"Employee ID: {eId}, Task: {task}\n";
                            }

                            textBox3.Text = completedTasks;
                        }
                        else
                        {
                            textBox3.Text = "No tasks are currently completed.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving completed tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchID_click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            string eId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(eId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"SELECT task FROM Employee WHERE e_id = '{eId}'";

            string conStr = UserFunctions.connectionString;

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Invalid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string task = result.ToString();
                            if (string.IsNullOrEmpty(task))
                            {

                            }
                            else
                            {
                                textBox2.Text = "Task is already assigned for this Employee ID.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking Employee ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assignButton_click(object sender, EventArgs e)
        {
            string eId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(eId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a task to assign.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string task = GetTaskForEmployee(eId);
            if (!string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Task is already assigned for this Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conStr = UserFunctions.connectionString;

            string updateQuery = $"UPDATE Employee SET task = '{textBox2.Text}', task_status = 'assigned' WHERE e_id = '{eId}' AND task IS NULL";

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(updateQuery, connection))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Task could not be assigned. Make sure the Employee ID is valid and the task is not already assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTaskForEmployee(string eId)
        {
            string conStr = UserFunctions.connectionString;

            string query = $"SELECT task FROM Employee WHERE e_id = '{eId}'";

            try
            {
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving task for Employee ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


    }
}
