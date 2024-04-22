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
    public partial class LoginPassenger : Form
    {
        public LoginPassenger()
        {
            int opacity = 85; // 50% of 255 (maximum alpha value)
            // Set the background color of the panel with adjusted opacity
            panel1.BackColor = Color.FromArgb(opacity, panel1.BackColor);


            InitializeComponent();
        }
    }
}
