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
    public partial class F_Party : Form
    {
        Global sqlConn = new Global();
        //SqlConnection Conn = new SqlConnection(@"Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");
        string mgPartyId;

        public F_Party()
        {
            InitializeComponent();
        }


        private void F_Party_Load(object sender, EventArgs e)
        {
            ShowPartyGrid();
        }


        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (btnAppend.Text == "Append")
            {
                activeField(true);
                btnAppend.Text = "Save";
                btnUpdate.Text = "Cancel";
                //btnReset.Visible = false;

            }
            else if (btnAppend.Text == "Save")
            {
                try
                {
                   // Global sqlConn = new Global();
                    sqlConn.MyConnection();
                    SqlCommand addParty = new SqlCommand("PartyAdd", sqlConn.sqlCon);
                    addParty.CommandType = CommandType.StoredProcedure;
                    addParty.Parameters.AddWithValue("@PName", txtPName.Text.Trim());
                    addParty.Parameters.AddWithValue("@PAddress", txtPAddress.Text.Trim());
                    addParty.Parameters.AddWithValue("@PMobile", txtPMobile.Text.Trim());
                    addParty.Parameters.AddWithValue("@PEmail", txtPEmail.Text.Trim());
                    addParty.Parameters.AddWithValue("@PContact", txtPContact.Text.Trim());
                    addParty.Parameters.AddWithValue("@GSTNo", txtGSTNo.Text.Trim());
                    sqlConn.sqlCon.Open();
                    addParty.ExecuteNonQuery();
                    ShowPartyGrid();
                    clearField();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Problem on Add: ", ex.Message);
                }

                finally
                {
                    if (sqlConn.sqlCon.State == ConnectionState.Open)
                    {
                        sqlConn.sqlCon.Close();

                    }

                }
            }
            else if (btnAppend.Text == "Update")
            {
 
                    sqlConn.MyConnection();

                try
                {
                    SqlCommand addParty = new SqlCommand("PartyEdit", sqlConn.sqlCon);
                    addParty.CommandType = CommandType.StoredProcedure;
                    addParty.Parameters.AddWithValue("@PartyId", mgPartyId);
                    addParty.Parameters.AddWithValue("@PName", txtPName.Text.Trim());
                    addParty.Parameters.AddWithValue("@PAddress", txtPAddress.Text.Trim());
                    addParty.Parameters.AddWithValue("@PMobile", txtPMobile.Text.Trim());
                    addParty.Parameters.AddWithValue("@PEmail", txtPEmail.Text.Trim());
                    addParty.Parameters.AddWithValue("@PContact", txtPContact.Text.Trim());
                    addParty.Parameters.AddWithValue("@GSTNo", txtGSTNo.Text.Trim());
                    sqlConn.sqlCon.Open();
                    //.Open();
                    addParty.ExecuteNonQuery();
                    ShowPartyGrid();
                    clearField();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Problem on Update: ", ex.Message);
                }

                finally
                {
                    if (sqlConn.sqlCon.State == ConnectionState.Open)
                    {
                        sqlConn.sqlCon.Close();

                    }

                }

            }


        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Cancel")
            {
                activeField(false);
                btnAppend.Text = "Append";
                btnUpdate.Text = "Exit";
                btnReset.Visible = false;
            }
            else if (btnUpdate.Text == "Exit")
            {
                this.Close();
            }
        }



        private void dgvPartyList_DoubleClick(object sender, EventArgs e)
        {
            activeField(true);
            btnAppend.Text = "Update";
            btnUpdate.Text = "Cancel";
            //btnReset.Visible = true;

            mgPartyId=dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["PartyId"].Value.ToString();
            txtPName.Text = dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["PName"].Value.ToString();
            txtPAddress.Text = dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["PAddress"].Value.ToString();
            txtPContact.Text = dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["PContact"].Value.ToString();
            txtPEmail.Text = dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["PEmail"].Value.ToString();
            txtPMobile.Text = dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["PMobile"].Value.ToString();
            txtGSTNo.Text = dgvPartyList.Rows[dgvPartyList.CurrentRow.Index].Cells["GSTNo"].Value.ToString();

           
        }



//=========================  All Function =============================================

        public void ShowPartyGrid()
        {
            sqlConn.MyConnection();
            SqlDataAdapter adPartyGrid = new SqlDataAdapter();
            DataTable dtPartyGrid = new DataTable();

            SqlCommand listParty = new SqlCommand("PartyList", sqlConn.sqlCon);
            listParty.CommandType = CommandType.StoredProcedure;
            adPartyGrid.SelectCommand = listParty;
            adPartyGrid.Fill(dtPartyGrid);
            dgvPartyList.AutoGenerateColumns = false;
            dgvPartyList.DataSource = dtPartyGrid;

        }


        public void clearField()
        {
                    txtPName.Text = null;
                    txtPAddress.Text = null;
                    txtPMobile.Text = null;
                    txtPEmail.Text = null;
                    txtPContact.Text = null;
                    txtGSTNo.Text = null;
                    txtPName.Focus();
        }

        public void activeField(Boolean af)
        {
            txtPName.Text = null;
            txtPAddress.Text = null;
            txtPMobile.Text = null;
            txtPEmail.Text = null;
            txtPContact.Text = null;
            txtGSTNo.Text = null;


            if (af == true)
            {

                txtPName.Enabled = true;
                txtPAddress.Enabled = true;
                txtPMobile.Enabled = true;
                txtPEmail.Enabled = true;
                txtPContact.Enabled = true;
                txtGSTNo.Enabled = true;

                txtPName.Focus();
            }
            else
            {
                txtPName.Enabled = false;
                txtPAddress.Enabled = false;
                txtPMobile.Enabled = false;
                txtPEmail.Enabled = false;
                txtPContact.Enabled = false;
                txtGSTNo.Enabled = false;

            }


        }


    }
}
