using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GUI_Application
{
    public partial class Form24 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        int r, max;

        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = "select * from AdminUser where UserName='" + txt1.Text + "' and Password='" + txt2.Text +"'";
            da = new OleDbDataAdapter(st, con);
            da.Fill(ds, "AdminUser");
            int max = ds.Tables["AdminUser"].Rows.Count;

            if(max == 1)
            {
                Form22 obj = new Form22();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Enter correct userid and password...!");
            }
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            r = 0;
            try
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/Visual Studio Project/Visual Studio 2008/student.mdb";
                con.Open();
                //MessageBox.Show("connected successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }
        }

        private void sign_clear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
        }
    }
}