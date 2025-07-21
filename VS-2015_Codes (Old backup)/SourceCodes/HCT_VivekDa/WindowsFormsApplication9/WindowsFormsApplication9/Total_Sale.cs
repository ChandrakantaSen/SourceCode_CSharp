using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    public partial class TotalSale : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=Password@123;");
        SqlDataAdapter da;
        DataTable dt = new DataTable();


        public TotalSale()
        {
            InitializeComponent();
        }



        private void datagridview1()
        {

            string command = "select * from BillingItem ";
            da = new SqlDataAdapter(command, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void TotalSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet9.BillingItem' table. You can move, or remove it, as needed.
            this.billingItemTableAdapter2.Fill(this.masterDataSet9.BillingItem);
            // TODO: This line of code loads data into the 'masterDataSet8.BillingItem' table. You can move, or remove it, as needed.
            this.billingItemTableAdapter1.Fill(this.masterDataSet8.BillingItem);
            // TODO: This line of code loads data into the 'masterDataSet2.ITEMS' table. You can move, or remove it, as needed.
            // this.billingItemTableAdapter.Fill(this.masterDataSet6.BillingItem);
            // TODO: This line of code loads data into the 'masterDataSet1.ITEMS' table. You can move, or remove it, as needed.

            datagridview1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HEXCODE-5-PC\RANCELAB2008;Persist Security Info=True;User ID=sa;Password=password@123;");
            conn.Open();
            SqlCommand cmdd = new SqlCommand("DELETE FROM [Billingitem]", conn);
            cmdd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("All the data has been Deleted");
            dataGridView1.Refresh();
        }

       
    }
}
