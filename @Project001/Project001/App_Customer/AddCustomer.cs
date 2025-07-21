using System;
using System.Windows.Forms;

namespace Project001.App_Customer
{
	public partial class AddCustomer : Form
	{
		public AddCustomer()
		{
			InitializeComponent();
		}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        //Save button
        private void button2_Click(object sender, EventArgs e)
        {
            int c,d;
            String nm = "",add = "",lndMrk = "", contNo = "", eml = "", vat = "", cst = "", gst = "", pan = "";

            //Object creation DAO.cs
            DAO.DAO connectObj = new DAO.DAO();
            
            //database connection -- connect()
            c = DAO.DAO.connect();

            if (c == 1)
            {
                nm     = textBox1.Text;
                add    = textBox2.Text;
                lndMrk = textBox3.Text;
                contNo = comboBox1.Text + "-" + textBox4.Text;
                eml    = textBox5.Text;
                vat    = textBox6.Text;
                cst    = textBox7.Text;
                gst    = textBox8.Text;
                pan    = textBox9.Text;

                //data insertion -- rcdInsrt()
                d = DAO.DAO.rcdInsrt(nm, add, lndMrk, contNo, eml, vat, cst, gst, pan);

                if (d == 1)
                {
                    MessageBox.Show("Data Inserted...!");
                }
                else
				{
                    MessageBox.Show("Data Not Inserted...!");
				}
            }
            else
            {
                MessageBox.Show("Database Connection Error...!");
            }
        }

        //Close Button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //New Button
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
