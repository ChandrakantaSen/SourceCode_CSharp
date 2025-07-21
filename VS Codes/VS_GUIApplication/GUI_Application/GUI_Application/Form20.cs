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
    public partial class Form20 : Form
    {
        string[] pic = new string[10];
        int i;

        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pb1.Image = Image.FromFile(pic[i]);
                button4.Enabled = true;
                button5.Enabled = true;
                i++;
                label1.Text = "pic " + i.ToString();
            }
        }

        private void Form20_Load(object sender, EventArgs e)
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

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pb1.Image = Image.FromFile(pic[i]);
                i++;
                label1.Text = "pic " + i.ToString();
            }
            else if (i == 9)
            {
                pb1.Image = Image.FromFile(pic[i]);
                button4.Enabled = false;
                button5.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                pb1.Image = Image.FromFile(pic[i]);
                i++;
                label1.Text = "pic " + i.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 9)
            {
                //pb1.Image = Image.FromFile(pic[i]);
                //label1.Text = "pic " + i.ToString();
                i--;
            }
            else if (i == 0)
            {
                pb1.Image = Image.FromFile(pic[i]);
                button4.Enabled = true;
                button5.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                pb1.Image = Image.FromFile(pic[i]);
                i--;
                label1.Text = "pic " + i.ToString();
            }
        }
    }
}
