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

namespace WindowsFormsApp1
{
    public partial class LoginPassenger : Form
    {
        public LoginPassenger()
        {
            InitializeComponent();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UserFunctions.Apply_Panel1_Transparency(panel1);
        }

        private void alreadyAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPassenger passengerSignUp = new SignUpPassenger();
            passengerSignUp.ShowDialog();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            SignUpPassenger passengerSignUp = new SignUpPassenger();
            passengerSignUp.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Dashboard.getDashboard().Show();

        }
    }
}
