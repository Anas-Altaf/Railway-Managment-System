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
    public partial class Dashboard : Form
    {
        LoginAdmin LoginForm1 = new LoginAdmin();
        public Dashboard()
        {
            InitializeComponent();
            // Attach event handlers for each button
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Change button color when mouse enters
            //((Button)sender).BackColor = System.Drawing.Color.LightGray;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Change button color when mouse leaves
            //((Button)sender).BackColor = System.Drawing.Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MakeLabelsTransparent(this);
            //this.Opacity = 1.0;
        }
        private void MakeLabelsTransparent(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Label)
                {
                    Label label = (Label)ctrl;
                    label.BackColor = Color.Transparent;
                }
                if (ctrl.HasChildren)
                {
                    MakeLabelsTransparent(ctrl);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int opacity = 85; // 50% of 255 (maximum alpha value)

            // Set the background color of the panel with adjusted opacity
            panel1.BackColor = Color.FromArgb(opacity, panel1.BackColor);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm1.Show();
            this.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
