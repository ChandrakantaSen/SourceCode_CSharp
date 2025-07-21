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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usrId, pwd;

            usrId = t1.Text;
            pwd = t2.Text;

            if (usrId == "tcs" && pwd == "pass")
            {
                Form5 obj = new Form5();

                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Error occured...!");
            }
        }

        //private string passwordchar(string p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
