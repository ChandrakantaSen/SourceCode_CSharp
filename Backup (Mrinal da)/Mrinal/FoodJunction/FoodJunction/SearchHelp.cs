using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodJunction
{
    public partial class SearchHelp : UserControl
    {

       SqlConnection Conn = new SqlConnection(@"Data Source = localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");

        public SearchHelp()
        {
            InitializeComponent();
        }


        public void cblItemShow()
        {
            {
                SqlDataAdapter adTabHelp = new SqlDataAdapter();
                DataSet dsTabHelp = new DataSet();
                SqlCommand cmdTabHelp = new SqlCommand("TableHelp", Conn);
                cmdTabHelp.CommandType = CommandType.StoredProcedure;
                cmdTabHelp.Parameters.AddWithValue("@SearchFilter",txtSearch.Text.Trim()); 
                adTabHelp.SelectCommand = cmdTabHelp;
                adTabHelp.Fill(dsTabHelp);
                chkListItem.DataSource = dsTabHelp.Tables[0];                
                chkListItem.ValueMember = "TabNo";
                chkListItem.DisplayMember = "TabDesc";
 
                Conn.Close();
            }
        }

        private void SearchHelp_Load(object sender, EventArgs e)
        {
            cblItemShow();
        }



    }
}
