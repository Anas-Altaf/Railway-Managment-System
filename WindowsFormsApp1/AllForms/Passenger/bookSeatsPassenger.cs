using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Passenger
{
    public partial class bookSeatsPassenger : Form
    {
        string conStr = UserFunctions.connectionString;
        public bookSeatsPassenger()
        {
            InitializeComponent();
        }

        private void bookSeatsPassenger_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT TRAIN_ID, ticket_id, DESTINATION, origin FROM TICKET";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string destination = reader["destination"].ToString();
                            string origin = reader["ORIGIN"].ToString();
                            string trainid = reader["train_id"].ToString();
                            string ticketid = reader["ticket_id"].ToString();
                            dataGridView1.Rows.Add(ticketid, trainid, origin, destination);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                trainBox.Text = selectedRow.Cells["train_id"].Value.ToString();
                destBox.Text = selectedRow.Cells["destination"].Value.ToString();
                originBox.Text = selectedRow.Cells["origin"].Value.ToString();
                ticketBox.Text = selectedRow.Cells["ticket_id"].Value.ToString();
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string origin = originBox.Text;
            string destination = destBox.Text;
            string sql = "SELECT TRAIN_ID, DESTINATION, origin FROM Trainschedule WHERE ORIGIN = :Origin AND DESTINATION = :Destination";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":Origin", OracleDbType.Varchar2).Value = origin;
                cmd.Parameters.Add(":Destination", OracleDbType.Varchar2).Value = destination;
                try
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            StringBuilder message = new StringBuilder("Matching trains:\n");
                            while (reader.Read())
                            {
                                string trainId = reader["TRAIN_ID"].ToString();
                                string dest = reader["DESTINATION"].ToString();
                                string orig = reader["origin"].ToString();

                                message.Append($"Trainid: {trainId},Origin: {orig}, Destination: {dest}\n");
                            }

                            MessageBox.Show(message.ToString(), "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No trains found for the provided origin and destination.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bookBtn_Click(object sender, EventArgs e)
        {
            string trainId = trainBox.Text;
            string ticketId = ticketBox.Text;
            string origin = originBox.Text;
            string destination = destBox.Text;
            bool trainExists = CheckTrainExists(trainId);
            if (!trainExists)
            {
                MessageBox.Show("The provided train ID does not exist in the TRAINSCHEDULE table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string insertSql = "INSERT INTO TICKET (train_id, ticket_id, origin, destination) VALUES (:TrainId, :TicketId, :Origin, :Destination)";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(insertSql, connection))
            {
                cmd.Parameters.Add(":TrainId", OracleDbType.Varchar2).Value = trainId;
                cmd.Parameters.Add(":TicketId", OracleDbType.Varchar2).Value = ticketId;
                cmd.Parameters.Add(":Origin", OracleDbType.Varchar2).Value = origin;
                cmd.Parameters.Add(":Destination", OracleDbType.Varchar2).Value = destination;
                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to book ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while booking the ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool CheckTrainExists(string trainId)
        {
            string sql = "SELECT COUNT(*) FROM TRAINSCHEDULE WHERE TRAIN_ID = :TrainId";
            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(sql, connection))
            {
                cmd.Parameters.Add(":TrainId", OracleDbType.Varchar2).Value = trainId;

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while checking the train ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string ticketId = cancelBox.Text;

            if (string.IsNullOrEmpty(ticketId))
            {
                MessageBox.Show("Please enter a ticket ID to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Delete the record from the TICKET table based on ticket ID
            string deleteSql = "DELETE FROM TICKET WHERE ticket_id = :TicketId";

            using (OracleConnection connection = new OracleConnection(conStr))
            using (OracleCommand cmd = new OracleCommand(deleteSql, connection))
            {
                cmd.Parameters.Add(":TicketId", OracleDbType.Varchar2).Value = ticketId;

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No matching ticket found to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("An error occurred while canceling the ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
