using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str="", tstr="";
            int length;

            if (c1.Checked)
            {
                str += "C, ";
            }
            if (c2.Checked)
            {
                str += "C++, ";
            }
            if (c3.Checked)
            {
                str += "C#, ";
            }
            length = ((str.Length) - 2);

            tstr = str.Substring(0, length); 
            MessageBox.Show("You have known "+tstr);
        }
    }
}
