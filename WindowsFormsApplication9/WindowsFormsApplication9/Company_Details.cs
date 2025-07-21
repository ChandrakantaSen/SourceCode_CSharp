using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication9
{
    public partial class Company_Details : Form
    {
        public Company_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox3.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength > 0)
            {
                Process.Start(textBox3.Text);
            }
            else
            {
                MessageBox.Show("You must select the Folder path");
            }  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void Company_Details_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }
    }
}
