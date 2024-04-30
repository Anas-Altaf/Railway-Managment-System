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
            // Query to select e_id and task where task_status = 'assigned'
            string query = "SELECT e_id, task FROM Employee WHERE task_status = 'assigned'";

            // Connection string
            string conStr = UserFunctions.connectionString;

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        // Create a DataTable to store the results
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the query results
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Check if any tasks are assigned
                        if (dataTable.Rows.Count > 0)
                        {
                            // Display the assigned tasks in textBox3
                            string assignedTasks = "";
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string eId = row["e_id"].ToString();
                                string task = row["task"].ToString();
                                assignedTasks += $"Employee ID: {eId}, Task: {task}\n";
                            }

                            // Display the tasks in textBox3
                            textBox3.Text = assignedTasks;
                        }
                        else
                        {
                            // Clear textBox3 if no tasks are assigned
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
            // Clear previous data from textBox3
            textBox3.Text = "";

            // Query to select e_id and task where task_status = 'completed'
            string query = "SELECT e_id, task FROM Employee WHERE task_status = 'completed'";

            // Connection string
            string conStr = UserFunctions.connectionString;

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        // Create a DataTable to store the results
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the query results
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Check if any tasks are completed
                        if (dataTable.Rows.Count > 0)
                        {
                            // Display the completed tasks in textBox3
                            string completedTasks = "";
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string eId = row["e_id"].ToString();
                                string task = row["task"].ToString();
                                completedTasks += $"Employee ID: {eId}, Task: {task}\n";
                            }

                            // Display the tasks in textBox3
                            textBox3.Text = completedTasks;
                        }
                        else
                        {
                            // Display a message if no tasks are completed
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
            // Clear previous data from textBox2
            textBox2.Text = "";

            // Get the e_id entered by the user
            string eId = textBox1.Text.Trim();

            // Check if eId is empty
            if (string.IsNullOrEmpty(eId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query to check if e_id exists in the Employee table
            string query = $"SELECT task FROM Employee WHERE e_id = '{eId}'";

            // Connection string
            string conStr = UserFunctions.connectionString;

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        // Execute the query and get the result
                        object result = cmd.ExecuteScalar();

                        // Check if e_id exists
                        if (result == null)
                        {
                            // Show message if e_id is invalid
                            MessageBox.Show("Invalid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Check if the task for this e_id is NULL
                            string task = result.ToString();
                            if (string.IsNullOrEmpty(task))
                            {
                                // Allow the user to enter data in textBox2
                                // Here you can add any additional logic you need for textBox2

                            }
                            else
                            {
                                // Display message if task is already assigned
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
            // Get the e_id entered by the user
            string eId = textBox1.Text.Trim();

            // Check if eId is empty
            if (string.IsNullOrEmpty(eId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if textBox2 contains data
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a task to assign.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the task for this e_id is already assigned
            string task = GetTaskForEmployee(eId);
            if (!string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Task is already assigned for this Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all conditions are met, assign the task to the employee
            string conStr = UserFunctions.connectionString;

            // Query to update the task and task_status for the employee
            string updateQuery = $"UPDATE Employee SET task = '{textBox2.Text}', task_status = 'assigned' WHERE e_id = '{eId}' AND task IS NULL";

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the update query
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

        // Method to get the task for a specific employee
        private string GetTaskForEmployee(string eId)
        {
            // Connection string
            string conStr = UserFunctions.connectionString;

            // Query to get the task for the employee
            string query = $"SELECT task FROM Employee WHERE e_id = '{eId}'";

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        // Execute the query and get the result
                        object result = cmd.ExecuteScalar();

                        // Check if the result is null or empty
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

            return null; // Return null if task is not found or an error occurs
        }


    }
}
