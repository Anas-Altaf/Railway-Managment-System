using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MailKit.Security;

namespace WindowsFormsApp1.Utilities
{
    public class EmailManager
    {
        public string SendEmail(string recipientAddress, string subject = "RMS One Time OTP")
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("RMS", "f223639@cfd.nu.edu.pk"));
            message.To.Add(new MailboxAddress("", recipientAddress));
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = @"A Test Mail for Our Railway Managment System" }; // Plain text body
            try
            {
                var client = new SmtpClient();
                
                    // Replace with your SMTP server details
                     client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls); // Use SSL

                    // Replace with your username and password (if required)
                    client.Authenticate("email@cfd.nu.edu.pk", "yourpass");

                    client.Send(message);
                     client.Disconnect(true); // Disconnect cleanly
                

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "Success";
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while sending the email: ";
                // Provide more specific error messages based on exception type (optional)
                if (ex is SmtpCommandException smtpEx)
                {
                    errorMessage += "\nSMTP Error: " + smtpEx.StatusCode;
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var error = ex.Message.ToString();
                return error;
            }
        }
    }
}

