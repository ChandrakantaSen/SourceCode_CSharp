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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l2.Items.Add(l1.SelectedItem);
            l1.Items.Remove(l1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cnt,i;
            cnt = l1.Items.Count;

            for (i = 0; i < cnt; i++)
            { 
                l2.Items.Add(l1.Items[i]);
            }

            for (i = (cnt-1); i >= 0; i--)
            {
                //l1.Items.Remove(l1.Items[i]);
                l1.Items.RemoveAt(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cnt, i;
            cnt = l1.Items.Count;

            for (i = 0; i < cnt; i++)
            {
                if (l1.GetSelected(i) == true)
                {
                    l2.Items.Add(l1.Items[i]);
                }
            }

            for (i = (cnt - 1); i >= 0; i--)
            {
                if (l1.GetSelected(i) == true)
                {
                    l1.Items.Remove(l1.Items[i]);
                }
            }
        }
    }
}
