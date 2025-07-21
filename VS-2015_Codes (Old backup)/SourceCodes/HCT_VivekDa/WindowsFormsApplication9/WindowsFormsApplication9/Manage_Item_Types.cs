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
    public partial class Manage_Item_Types : Form
    {
        
      SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=Password@123;");
      SqlDataAdapter da;
      DataTable dt = new DataTable();
    
      public Manage_Item_Types()
        {
            InitializeComponent();
        }

      private void datagridview1()
      {

          string command = "select * from ITEMS ";
          da = new SqlDataAdapter(command, con);
          da.Fill(dt);
          dataGridView1.DataSource = dt;
      }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manage_Item_Types_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet2.ITEMS' table. You can move, or remove it, as needed.
            this.iTEMSTableAdapter1.Fill(this.masterDataSet2.ITEMS);
            // TODO: This line of code loads data into the 'masterDataSet1.ITEMS' table. You can move, or remove it, as needed.
          
            datagridview1();


            

        }

        


        private void button7_Click(object sender, EventArgs e)
        {
          


        }

        private void item_TypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [ITEMS](ID, Name, [Sales Price], [Purchase Price], Barcode, Vendor,[Date and Time],Quantity)VALUES ('" + textBox2.Text + "','" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "', '" + numericUpDown1.Value + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your data has been added successfully");
            }

            catch (Exception)
            {
                MessageBox.Show("Error !!" +Environment.NewLine+"You have made some mistake");
            }
            
            }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Your data has been saved successfully to the database");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE       [ITEMS]SET Name ='" + textBox1.Text + "', [Sales Price] ='" + maskedTextBox1.Text + "', [Purchase Price] ='" + maskedTextBox2.Text + "', Barcode ='" + maskedTextBox3.Text + "', Vendor ='" + textBox3.Text + "',[Date and Time] = '" + dateTimePicker1.Value.Date + "' ,Quantity = '"+numericUpDown1.Value+"'   WHERE (ID ='" + textBox2.Text + "' )", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your data has been updated successfully");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Manage_Item_Types_Search obj1 = new Manage_Item_Types_Search();
            obj1.Show();
        }

       

       
       


       

       
    }
}
