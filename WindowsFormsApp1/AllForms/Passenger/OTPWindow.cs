using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.AllForms.Passenger
{
    public partial class OTPWindow : Form
    {
         EmailManager emailManager = new EmailManager();

        int OTP= GenerateOtp();
        public bool OTPStatusInfo = false;
        string recipientAddressinOTP;
        bool emailStatus = false;
        public OTPWindow(string recipientAddress)
        {

            emailStatus = emailManager.SendEmail(recipientAddress, OTP);
            recipientAddressinOTP = recipientAddress;
            InitializeComponent();
        }
        //OTP generation 
        public static int GenerateOtp()
        {
            // Use a Random class instance
            var random = new Random();

            // Alternative approach: Generate a random number between 100000 and 999999 (inclusive)
            int randomNumber = random.Next(100000, 1000000);

            return randomNumber;
        }
        //public bool verifyOTPStatus(string recipientAddress)
        //{
        //   if(OTP >= 100000 && emailStatus == true)
        //    {

        //    }

        //    try
        //    {
               
        //        if (emailStatus)
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions (refer to previous explanation)
        //        MessageBox.Show("Error sending Email OTP: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.Close();
        //    }
        //}
        private void OTPVerifyButton_Click(object sender, EventArgs e)
        {
            OTP = GenerateOtp();

            //string subject = "Your Email Subject";
            //string body = "Your Email Message";

            try
            {
                //var emailStatus = emailManager.SendEmail(recipientAddress, OTP);
                //if(emailStatus)
                //{
                   
                //}
            }
            catch (Exception ex)
            {
                // Handle exceptions (refer to previous explanation)
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
