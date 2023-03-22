using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitB_Click(object sender, EventArgs e)
        {
            string str = " ";

            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            }
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            }
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            }
            if (othersCheckBox.Checked == true)
            {
                str = str + othersTextBox.Text;
                str += " ";
            }
            if (str != null)
            {
                MessageBox.Show("You Selected: \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}

