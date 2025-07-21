using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DOB_WinForms
{
    public partial class Form9 : Form
    {
        public static string str = "";

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DateForm2 dFrm2 = new DateForm2();
                this.Hide();
                dFrm2.Show(this);

                str = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                MonthForm2 mFrm2 = new MonthForm2();
                this.Hide();
                mFrm2.Show(this);

                str = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                DayForm2 dyFrm2 = new DayForm2();
                this.Hide();
                dyFrm2.Show(this);

                str = radioButton3.Text;
            }
            else
            {
                MessageBox.Show("Please choose the proper option...!");
            }
        }
    }
}
