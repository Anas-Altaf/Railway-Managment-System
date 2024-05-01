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
    public partial class MainAdminPage : Form
    {
        Form pageForm;
        Label mainTitle= new Label() ;
        private AdminDashboard updateForm;         public void LoadPage(Form _pageForm)
        {

            centralPanel.Controls.Clear();
            pageForm = _pageForm;
            pageForm.Dock = DockStyle.Fill;
            pageForm.TopLevel = false;
            centralPanel.Controls.Add(pageForm);
            pageForm.Show();
        }
        public MainAdminPage()
        {
            InitializeComponent();
            updateForm = new AdminDashboard();
        }

        private void adminCheckProfileBtn_Click(object sender, EventArgs e)
        {
                       

        }



        private void adminManageProfileBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void adminManageScheduleBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void adminRevenueBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void adminViewTrainsBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void adminTasksBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void adminViewFeedbackBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
