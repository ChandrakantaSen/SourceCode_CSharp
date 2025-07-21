using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace GUI_Application
{
    public partial class Form22 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Chandra/Documents/Visual Studio 2008/student.mdb";
                con.Open();
                MessageBox.Show("connected successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            string st="select * from studentinfo";
            da = new OleDbDataAdapter(st, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
