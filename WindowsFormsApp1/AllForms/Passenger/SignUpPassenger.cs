using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AllForms.Passenger;
using WindowsFormsApp1.Static_Resources;

namespace WindowsFormsApp1
{
    public partial class SignUpPassenger : Form
    {
        string passengerEmail;
       private string passengerName ; 
         string passengerPhoneNumber;
        string passengerCNIC;
        string passengerPass; 
        public SignUpPassenger()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UserFunctions.Apply_Panel1_Transparency(panel1);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dashboard.getDashboard().Show();
        }
        private void alreadyHaveAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoginPassenger passengerLoginForm = new LoginPassenger();
            passengerLoginForm.Show();
        }

        private void SignUpPassenger_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard.getDashboard().Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            passengerEmail = emailBox.Text.ToString();
            passengerName = NameBox.Text.ToString();
            passengerPhoneNumber = phoneNumberBox.Text.ToString();
            passengerCNIC = cnicBox.Text.ToString();
            passengerPass = passwordBox.Text.ToString();
            bool signUpInputStatus = UserFunctions.ValidateUserInput(passengerEmail, passengerPhoneNumber, passengerCNIC, passengerName, this);
            //Check if already Exists or Not

            if(signUpInputStatus)
            {
                statusBarTextBox.Text = @"Great!, You got the right format.";
                statusBarTextBox.Text = @"Checkin for Existing Accounts!";

                var otpObj = new OTPWindow();
                otpObj.ShowDialog();


            }

        }
    }
}
