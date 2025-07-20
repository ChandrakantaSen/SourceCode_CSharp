using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

namespace Project001.App_Customer
{
    public partial class ViewCustomer : Form
    {
        public string srchBox = "";

        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
           
        }

		private void ViewCustomer_Load(object sender, EventArgs e)
        {
            DAO.DAO.AllshowData();
            dataGridView1.DataSource = DAO.DAO.dt;
        }

        private void seachBtn_Click(object sender, EventArgs e)
		{
            this.Hide();
		}

		private void searchBox_TextChanged(object sender, EventArgs e)
		{
            srchBox = searchBox.Text;
            DAO.DAO.showData(srchBox);
            dataGridView1.DataSource = DAO.DAO.dt;
        }
	}
}
