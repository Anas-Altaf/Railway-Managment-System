using Oracle.ManagedDataAccess.Client;
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
using WindowsFormsApp1.Static_Resources;
using WindowsFormsApp1.Utilities;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1.AllForms.Passenger
{
    public partial class OTPWindow : Form
    {
         EmailManager emailManager = new EmailManager();
        string conStr = UserFunctions.connectionString;

       int OTP;
        bool OTPStatusInfo = false;
        string _recipientAddress = "f223639@cfd.nu.edu.pk";
        bool emailStatus = false;
        public bool OTPStatusInfo1 { get => OTPStatusInfo; set => OTPStatusInfo = value; }

        public OTPWindow(string recipientAddress)
        {

            OTP = GenerateOtp();
            emailStatus = emailManager.SendEmail(recipientAddress, OTP);
            _recipientAddress = recipientAddress;
            InitializeComponent();
        }
        //OTP generation 
        public int GenerateOtp()
        {
            // Use a Random class instance
            var random = new Random();

            // Alternative approach: Generate a random number between 100000 and 999999 (inclusive)
            int randomNumber = random.Next(100000, 1000000);

            return randomNumber;
        }
       
        private void OTPVerifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailStatus)
                {
                    if(OTPBox.Text.ToString().Trim() == OTP.ToString().Trim())
                    {
                        OTPStatusInfo = true;
                        otpStatusBoxIcon.Visible = true;
                        //Saving Correct OTP
                        string sql = "INSERT INTO emailotp (p_email_id, p_otp_code) VALUES (:email, :otp)";

                        try
                        {
                            using (OracleConnection connection = new OracleConnection(conStr))
                            {
                                connection.Open();

                                using (OracleCommand cmd = new OracleCommand(sql, connection))
                                {
                                    cmd.Parameters.Add(new OracleParameter(":email", _recipientAddress));
                                    cmd.Parameters.Add(new OracleParameter(":otp", OTP)); 

                                    cmd.ExecuteNonQuery();
                                   // Console.WriteLine("OTP saved successfully for: " + _recipientAddress); 
                                }
                            }
                        }
                        catch (OracleException ex)
                        {
                            //Console.WriteLine("An error occurred while saving OTP to the database: " + ex.Message);
                            MessageBox.Show("An error occurred while saving OTP to the database: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        otpStatusBoxIcon.Image = Properties.Resources.icons8_cross;
                        otpStatusBoxIcon.Visible = true;
                        MessageBox.Show(@"❌Invalid OTP...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email verification error: " + "Sorry, Check your email! Email could not be sent, Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
       
                MessageBox.Show("Error verifying email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void resendOTPLabel_Click(object sender, EventArgs e)
        {
            emailStatus = emailManager.SendEmail(_recipientAddress, OTP);
        }
    }
}
