using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace WindowsFormsApplication9
{
    public partial class Authentication_Required : Form
    {
        public Authentication_Required()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login2 where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome "+textBox1.Text);

                this.Hide();

                Search_Sales obj1 = new Search_Sales();
                obj1.Show();

            }



            else
            {

                MessageBox.Show("Please check your USERNAME and PASSWORD");
                ErrorProvider erp = new ErrorProvider();
                erp.SetError(textBox1, "q");
                erp.SetError(textBox2, "q");
            }
        }


        private void Authentication_Required_Load(object sender, EventArgs e)
        {

        }

        
    }
}
