using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Static_Resources
{
    public class UserFunctions
    {
        public static void Apply_Panel1_Transparency(Panel panel1)
        {
            int opacity = 80;
            panel1.BackColor = Color.FromArgb(opacity, panel1.BackColor);
            
        }
    }
}
