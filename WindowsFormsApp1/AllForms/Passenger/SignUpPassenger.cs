using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUpPassenger : Form
    {
        public SignUpPassenger()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int opacity = 85; // 50% of 255 (maximum alpha value)

            // Set the background color of the panel with adjusted opacity
            panel1.BackColor = Color.FromArgb(opacity, panel1.BackColor);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboardObj = new Dashboard();
            dashboardObj.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
