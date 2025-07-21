using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;




namespace WindowsFormsApplication9
{
    public partial class Add_Purchases : Form
    {
        public Add_Purchases()
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
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [ITEMS](ID, Name, Vendor,[Date and Time],Quantity)VALUES ('" + textBox1.Text + "','" + comboBox1 + "','" + comboBox2 + "','" + dateTimePicker1.Value.Date + "','" + numericUpDown1.Value + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
 
            MessageBox.Show("New stock is updated successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        }

        private void Add_Purchases_Load(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ITEMS", cs);


            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["Vendor"]);
                comboBox1.Items.Add(dt.Rows[i]["Name"]);
                comboBox3.Items.Add(dt.Rows[i]["ID"]);
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}
