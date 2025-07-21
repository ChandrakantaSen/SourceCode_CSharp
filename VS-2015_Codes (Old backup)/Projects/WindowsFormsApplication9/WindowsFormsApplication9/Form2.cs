using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;


namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int a = 0;

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.hexcodetechnologies.com");
        }

        private void adjssadsdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_password obj1 = new Change_password();
            obj1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            

            SqlConnection cs = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ITEMS", cs);


            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                comboBox1.Items.Add(dt.Rows[i]["Name"]);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString().Substring(DateTime.Today.ToString().Length - 11);
            label6.Text = DateTime.Now.ToShortDateString();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Change_password obj1 = new Change_password();
            obj1.Show();
            
        }

        private void manageItemTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Item_Types obj1 = new Manage_Item_Types();
            obj1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Item_Types obj1 = new Manage_Item_Types();
            obj1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Purchases obj1 = new Add_Purchases();
            obj1.Show();
        }

        private void addPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Purchases obj1 = new Add_Purchases();
            obj1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel9.Show();

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
           // textBox9.Clear();
            

            
        }

        private void saleItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel9.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Authentication_Required obj1 = new Authentication_Required();
            obj1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel9.Hide();
            panel8.Show();
        }

        private void searchSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authentication_Required obj1 = new Authentication_Required();
            obj1.Show();
        }

        private void manageContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Contractor obj1 = new Manage_Contractor();
            obj1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Vendor obj1 = new Manage_Vendor();
            obj1.Show();
        }

        private void companyDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Company_Details obj1 = new Company_Details();
            obj1.Show();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_A_Bug obj1 = new Report_A_Bug();
            obj1.Show();
        }

        private void sendUsFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Send_Us_Feedback obj1 = new Send_Us_Feedback();
            obj1.Show();
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) 
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "SMS has been minimised";
                notifyIcon1.ShowBalloonTip(1000);

            }
        
         else if  (this.WindowState == FormWindowState.Normal) 


            {
                notifyIcon1.BalloonTipText = "SMS has come back to normal mode";
                notifyIcon1.ShowBalloonTip(1000);
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit obj1 = new Exit();
            obj1.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Manage_Item_Types obj1 = new Manage_Item_Types();
            obj1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Add_Purchases obj1 = new Add_Purchases();
            obj1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Authentication_Required obj1 = new Authentication_Required();
            obj1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select Sl No.,Item Types,Quantity and Sales Price");

            }

            else if (string.IsNullOrEmpty(textBox5.Text))
            {

                MessageBox.Show("Please select Sl No.,Item Types,Quantity and Sales Price");
            }

            else if (string.IsNullOrEmpty(textBox6.Text))
            {

                MessageBox.Show("Please select Sl No.,Item Types,Quantity and Sales Price");
            }

            else if (string.IsNullOrEmpty(textBox8.Text))
            {

                MessageBox.Show("Please select Sl No.,Item Types,Quantity and Sales Price");
            }


            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Salesitem]([Sales Price],[Date and Time],Quantity,[Item type])VALUES ('" + textBox5.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox6.Text + "','" + comboBox1.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();



                    panel9.Hide();
                    panel8.Show();

                    SqlConnection conn = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand("INSERT INTO [Billingitem]([Sl No.],[Item type], Quantity, [Sales Price])VALUES ('" + textBox8.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    conn.Close();

                    dataGridView1.Refresh();

                }

                catch (Exception)
                {
                    MessageBox.Show("ERROR" + Environment.NewLine + "Please select differnt Sl No.");
                }

                try
                {

                    textBox4.Text = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox6.Text)).ToString();

                }
                catch (System.FormatException)
                { }

                textBox7.Text = textBox8.Text;

            }

   
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox8.Clear();
            textBox5.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            SqlConnection Conn = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123");
            SqlCommand Comm1 = new SqlCommand("Select [Sales Price] from ITEMS where Name ='" + comboBox1.Text + "'", Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                textBox6.Text = DR1.GetValue(0).ToString();
            }
            Conn.Close();

           // string constring = @"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123";
           // string Query = "Select * from BillingItem where name='" + comboBox1.Text + "'";
           // SqlConnection conDataBase = new SqlConnection(constring);
          //  SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
          //  SqlDataReader myReader;

          //  try
          //  {
            //    conDataBase.Open();
             //   myReader = cmdDataBase.ExecuteReader();

             //   while (myReader.Read())
             //   {
                 //   string sSalesPrice = myReader.GetInt32("Sales Price").ToString();
                //    textBox6.Text = sSalesPrice;
             //   }

           // }

           // catch(Exception)
           // {
           //     MessageBox.Show("Error");
           // }
            



            
            
            
            //SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            //con.Open();
            //DataTable dta = new DataTable();
            //SqlDataAdapter s = new SqlDataAdapter("select Quantity from ITEMS where Name = ('"+comboBox1.Text+"')", con);
            //s.Fill(dta);
            //dataGridView1.DataSource = dta;


            textBox4.Text = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox6.Text)).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            conn.Open();
            SqlCommand cmdd = new SqlCommand("DELETE from [Billingitem] where [Sl No.]='" + textBox8.Text + "'", conn);
            cmdd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted");
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TotalSale obj1 = new TotalSale();
            obj1.Show();
            panel9.Refresh();
            dataGridView1.Refresh();
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {
                // to prevent exception appearing
            }
            else
            {

                textBox9.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox9.Text)).ToString();
                   
                }

                textBox4.Clear();
            }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TotalSale obj1 = new TotalSale();
            obj1.Show();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123");
            SqlCommand Comm1 = new SqlCommand("Select [Sales Price] from ITEMS where Name ='" + comboBox1.Text + "'", Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                textBox6.Text = DR1.GetValue(0).ToString();
            }
            Conn.Close();

            textBox4.Text = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox6.Text)).ToString();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                // to prevent exception appearing
            }
            else
            {

                textBox9.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox9.Text)).ToString();

            }

            textBox4.Clear();

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Salesitem]([Sales Price],[Date and Time],Quantity,[Item type])VALUES ('" + textBox5.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox6.Text + "','" + comboBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();



               

                SqlConnection conn = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
                conn.Open();
                SqlCommand cmdd = new SqlCommand("INSERT INTO [Billingitem]([Sl No.],[Item type], Quantity, [Sales Price])VALUES ('" + textBox8.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", conn);
                cmdd.ExecuteNonQuery();
                conn.Close();

                dataGridView1.Refresh();

            }

            catch (Exception)
            {
                MessageBox.Show("ERROR" + Environment.NewLine + "Please select differnt Sl No.");
            }

            string ab = Convert.ToInt32(textBox8.Text).ToString();
            textBox7.Text = ab;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel9.Hide();
            panel8.Show();
            

            string a = Convert.ToInt32(textBox9.Text).ToString();
             textBox1.Text = a ;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            textBox3.Text = (Convert.ToInt32(textBox10.Text) - Convert.ToInt32(textBox1.Text)).ToString();
            label9.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox1.Clear();
            textBox3.Clear();
            label9.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }
  
       }
    }
        

      

       

      

       
        

      
     

      

       
       

        

       

        

        


    
