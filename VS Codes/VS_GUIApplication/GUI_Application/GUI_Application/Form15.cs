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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Items.Add(t1.Text);
            t1.Clear();
            t1.Focus();
            MessageBox.Show("Items added...!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l1.Items.Remove(l1.SelectedItem.ToString());
            t1.Clear();
            t1.Focus();
            MessageBox.Show("Items deleted...!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            l1.Items.Clear();
            t1.Clear();
            t1.Focus();
            MessageBox.Show("All clear...!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cnt;
            cnt = l1.Items.Count;
            t1.Clear();
            t1.Focus();
            MessageBox.Show("Total number of elements are "+cnt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l1.Sorted = true;
            //l1.Items.Clear();
            t1.Clear();
            t1.Focus();
            MessageBox.Show("All elements are sorted...!");
        }
    }
}
