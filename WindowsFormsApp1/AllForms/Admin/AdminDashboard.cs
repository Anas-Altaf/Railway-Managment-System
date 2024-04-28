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
        Form pageForm;
        bool sideBarExpand;

        public void LoadPage(Form _pageForm )
        {

            centralPanel.Controls.Clear();
            pageForm = _pageForm;
            pageForm.Dock = DockStyle.Fill;
            pageForm.TopLevel = false;
            centralPanel.Controls.Add(pageForm);
            pageForm.Show();
        }

        public AdminDashboard()
        {

            InitializeComponent();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
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

        //
        private void AdminDashboard_Activated(object sender, EventArgs e)
        {
            LoadPage(new MainAdminPage());
        }
        //Back button
        private void backButton_Click(object sender, EventArgs e)
        {
            LoadPage(new MainAdminPage());
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }


        private void adminCheckProfileBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new checkProfileAdmin());
        }

 

        private void adminManageProfileBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new manageProfileAdmin());
        }

        private void adminManageScheduleBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new manageTrainAdmin());
        }

        private void adminRevenueBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new viewTrainAdmin());
        }

        private void adminViewTrainsBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new viewTrainAdmin());
        }

        private void adminTasksBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new assignTasksAdmin());

        }

        private void adminViewFeedbackBtn_Click(object sender, EventArgs e)
        {
            LoadPage(new viewFeedbacksAAdmin());
        }

        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.getDashboard().Show();
        }
    }
}
