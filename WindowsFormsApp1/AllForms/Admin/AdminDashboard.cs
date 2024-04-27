using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AllForms.Admin;

namespace WindowsFormsApp1
{
    public partial class AdminDashboard : Form
    {
        bool sideBarExpand;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if(sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var chechProfileAdmin = new checkProfileAdmin();
            chechProfileAdmin.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var chechProfileAdmin = new checkProfileAdmin();
            chechProfileAdmin.Show();
        }
    }
}
