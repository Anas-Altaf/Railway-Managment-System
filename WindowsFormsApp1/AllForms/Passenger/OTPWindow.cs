using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.AllForms.Passenger
{
    public partial class OTPWindow : Form
    {
         EmailManager emailManager = new EmailManager();
        public OTPWindow()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string recipientAddress = "f223639@cfd.nu.edu.pk";
            //string subject = "Your Email Subject";
            //string body = "Your Email Message";

            try
            {
                var error = emailManager.SendEmail(recipientAddress);
                OTPBox.Text = error.ToString();
                MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions (refer to previous explanation)
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }
    }
}
