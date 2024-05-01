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

namespace WindowsFormsApp1.AllForms.Admin
{
    public partial class adminProfile : Form
    {
        private TextBox adminNameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        public adminProfile()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dashboard.getDashboard().Show();
            }
        }

        private void adminName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
