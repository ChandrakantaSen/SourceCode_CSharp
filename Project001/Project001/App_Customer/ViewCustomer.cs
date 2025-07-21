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

        public static DataTable dt = null;
        public static SqlDataReader sdr = null; 

        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
           
        }
    }
}
