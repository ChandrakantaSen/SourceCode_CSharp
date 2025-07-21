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
    public partial class Form18 : Form
    {
        int i;
        public Form18()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb1.Value <= pb1.Maximum)
            {
                if (pb1.Value == 100)
                {
                    timer1.Stop();
                    Form17 obj = new Form17();
                    obj.Show(); 
                    this.Hide();
                }
                else 
                {
                    pb1.Value = pb1.Value + 10;
                    label1.Text =" Remaining time " +i + " sec...";
                    i--;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == "admin" && t2.Text == "Cisco001")
            {
                timer1.Start();
            }
            else
            {
                l1.Text="enter the correct credentials...try again !";
            }
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            i=10;
        }
    }
}
