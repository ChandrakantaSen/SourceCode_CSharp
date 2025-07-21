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
    public partial class Form19 : Form
    {
        string []pic = new string[10];
        int i;

        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            i = 0;
            pic[0] = "e:/pics/1.jpg";
            pic[1] = "e:/pics/2.jpg";
            pic[2] = "e:/pics/3.jpg";
            pic[3] = "e:/pics/4.jpg";
            pic[4] = "e:/pics/5.jpg";
            pic[5] = "e:/pics/6.jpg";
            pic[6] = "e:/pics/7.jpg";
            pic[7] = "e:/pics/8.jpg";
            pic[8] = "e:/pics/9.jpg";
            pic[9] = "e:/pics/10.jpg";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            if (i == 10)
            {
                i = 0;
            }
            pb1.Image = Image.FromFile(pic[i]);
            i++;

            label1.Text = "pic " + i.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Stop();
            i = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Stop();
        }
    }
}
