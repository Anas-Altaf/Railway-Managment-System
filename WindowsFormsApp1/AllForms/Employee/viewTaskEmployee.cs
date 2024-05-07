using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AllForms.Employee
{
    public partial class viewTaskEmployee : Form
    {
        public viewTaskEmployee()
        {
            InitializeComponent();
        }

        private void btnCompletedTasks_Click(object sender, EventArgs e)
        {
            listBoxCompleteTasks.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                listBoxCompleteTasks.Items.Add(s);
        }


        private void btnTodoTasks_Click(object sender, EventArgs e)
        {
            listBoxTodoTasks.Items.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    listBoxTodoTasks.Items.Add(checkedListBox1.Items[i]);
                }
            }
        }
    }
}
