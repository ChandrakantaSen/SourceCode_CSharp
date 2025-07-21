using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Report_A_Bug : Form
    {
        public Report_A_Bug()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select all the values");
            } 
              
            else if (string.IsNullOrEmpty(comboBox2.Text) )
            {

                MessageBox.Show("Please select all the values");
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Please select all the values");
            }
            else if(string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Please select all the values");
            }
            else
            {
                MessageBox.Show("Thank you for reporting a bug !" + Environment.NewLine + "Your suggestions are highly appreciated ! ");
                this.Close();
            
            }

            
            
        }
    }
}
