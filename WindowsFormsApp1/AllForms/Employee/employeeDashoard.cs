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

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class employeeDashoard : Form
    {
        Form pageForm;
        bool sideBarExpand;
        Timer timer = null;
        string _email = "umair@employee.com";
        private void ShowTempText(string text, int durationSeconds)
        {

            tempInfo.Text = text;

            tempInfo.Visible = true;

            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = durationSeconds * 1000;
                timer.Tick += OnTimerElapsed;
            }
            timer.Start();
        }
        private void OnTimerElapsed(object sender, EventArgs e)
        {
            tempInfo.Visible = false;
            timer.Stop();
        }
        public void LoadPage(Form _pageForm)
        {

            centralPanel.Controls.Clear();
            pageForm = _pageForm;
            pageForm.Dock = DockStyle.Fill;
            pageForm.TopLevel = false;
            centralPanel.Controls.Add(pageForm);
            pageForm.Show();
        }


        public employeeDashoard()
        {
            InitializeComponent();
        }
        public employeeDashoard(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Employee Dashboard";
            LoadPage(new employeeProfile(_email));
        }

        private void EmpProfileButton_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Employee Profile";
            LoadPage(new employeeProfile(_email));
        }

        private void EmpCheckProfileBtn_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Employee Profile";
            LoadPage(new employeeProfile(_email));
        }

        private void EmpSalaryBtn_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Employee Salary";
            LoadPage(new salaryEmployee());
        }

        private void EmpManageTaskBtn_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Employee Tasks";
            LoadPage(new viewTaskEmployee());
        }

        private void EmpSupportBtn_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Help and Support";
            LoadPage(new helpSupportEmployee());
        }

        private void EmpSelTicketBtn_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Manage Tickets ";
            LoadPage(new sellTicketsEmployee());
        }

        private void EmpLogoutBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dashboard.getDashboard().Show();
            }
            else
            {
                ShowTempText("Logout action declined!", 3);

            }
        }

        private void employeeDashoard_Load(object sender, EventArgs e)
        {
            mainTitle.Text = "Employee Dashboard";
            LoadPage(new employeeProfile(_email));
        }
    }
}
