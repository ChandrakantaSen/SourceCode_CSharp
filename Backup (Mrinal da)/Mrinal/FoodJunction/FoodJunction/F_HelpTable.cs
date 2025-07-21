using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FoodJunction
{
    public partial class F_HelpTable : Form
    {

        SqlConnection Conn = new SqlConnection(@"Data Source = localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");

        string tabSel;

        public F_HelpTable()
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
                cmdTabHelp.Parameters.AddWithValue("@SearchFilter", txtSearch.Text.Trim());
                adTabHelp.SelectCommand = cmdTabHelp;
                adTabHelp.Fill(dsTabHelp);
                chkListItem.DataSource = dsTabHelp.Tables[0];
                chkListItem.DisplayMember = "TabDesc";

                Conn.Close();
            }
        }

        private void F_HelpTable_Load(object sender, EventArgs e)
        {
            cblItemShow();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cblItemShow();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tabSel = "";
            try
            {
                if (chkListItem.CheckedItems.Count > 0)
                {
                             foreach (var tabSelItem in this.chkListItem.CheckedItems)
                            {

                                tabSel += this.chkListItem.GetItemText(tabSelItem).Trim() + '/';
                            }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }


            MessageBox.Show(tabSel);
        }
    }
    }



