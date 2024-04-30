using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1.AllForms.Admin
{
    public partial class revenuePdfAdmin : Form
    {
        public revenuePdfAdmin()
        {
            InitializeComponent();
        }

        private void DownloadPDFButton_Click(object sender, EventArgs e)
        {
            // Calculate total revenue, total employees, and total passengers
            decimal totalRevenue = CalculateTotalRevenue();
            int totalEmployees = GetTotalEmployees();
            int totalPassengers = GetTotalPassengers();

            // Create PDF document
            Document document = new Document();
            try
            {
                // Define output file path
                string outputPath = "TotalRevenueReport.pdf";

                // Create PDF writer
                PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

                // Open document for writing
                document.Open();

                // Add content to the document
                document.Add(new Paragraph("Total Revenue Report"));
                document.Add(new Paragraph($"Total Revenue: ${totalRevenue}"));
                document.Add(new Paragraph($"Total Employees: {totalEmployees}"));
                document.Add(new Paragraph($"Total Passengers: {totalPassengers}"));

                // Show success message
                MessageBox.Show("PDF report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the PDF file after generation
                System.Diagnostics.Process.Start(outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the document
                document.Close();
            }
        }

        private decimal CalculateTotalRevenue()
        {
            decimal totalTicketPrice = 0;
            decimal totalEmployeeSalary = 0;

            // Query to sum ticket prices from the passenger table
            string ticketPriceQuery = "SELECT SUM(ticket_price) FROM Passenger";

            // Query to sum employee salaries from the employee table
            string employeeSalaryQuery = "SELECT SUM(e_salary) FROM Employee";

            // Connection string
            string conStr = UserFunctions.connectionString;

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Calculate total ticket price
                    using (OracleCommand cmd = new OracleCommand(ticketPriceQuery, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalTicketPrice = Convert.ToDecimal(result);
                        }
                    }

                    // Calculate total employee salary
                    using (OracleCommand cmd = new OracleCommand(employeeSalaryQuery, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalEmployeeSalary = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total revenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Calculate and return total revenue
            return totalTicketPrice - totalEmployeeSalary;
        }

        private int GetTotalEmployees()
        {
            int totalEmployees = 0;

            // Query to count total employees
            string employeeCountQuery = "SELECT COUNT(*) FROM Employee";

            // Connection string
            string conStr = UserFunctions.connectionString;

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute query to get total employees
                    using (OracleCommand cmd = new OracleCommand(employeeCountQuery, connection))
                    {
                        totalEmployees = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalEmployees;
        }

        private int GetTotalPassengers()
        {
            int totalPassengers = 0;

            // Query to count total passengers
            string passengerCountQuery = "SELECT COUNT(*) FROM Passenger";

            // Connection string
            string conStr = UserFunctions.connectionString;

            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection(conStr))
                {
                    // Open the connection
                    connection.Open();

                    // Execute query to get total passengers
                    using (OracleCommand cmd = new OracleCommand(passengerCountQuery, connection))
                    {
                        totalPassengers = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total passengers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalPassengers;
        }
    }
}
