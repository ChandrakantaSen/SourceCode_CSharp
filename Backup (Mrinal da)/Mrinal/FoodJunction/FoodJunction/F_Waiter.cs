using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;


namespace FoodJunction
{
    public partial class F_Waiter : Form
    {

        //Vriable Declare for this Form 

        Global sqlConn = new Global();
        //SqlConnection Conn = new SqlConnection(@"Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");
        string mgWaiterId;

        public F_Waiter()
        {
            InitializeComponent();
        }


        private void F_Waiter_Load(object sender, EventArgs e)
        {
            ShowWaiterGrid();
        }


        public void ShowWaiterGrid()
        {
            sqlConn.MyConnection();
            SqlDataAdapter adWaiterGrid = new SqlDataAdapter();
            DataTable dtWaiterGrid = new DataTable();

            SqlCommand listWaiter = new SqlCommand("WaiterList", sqlConn.sqlCon);
            listWaiter.CommandType = CommandType.StoredProcedure;
            adWaiterGrid.SelectCommand = listWaiter;
            adWaiterGrid.Fill(dtWaiterGrid);
            dgvWaiterList.AutoGenerateColumns = false;
            dgvWaiterList.DataSource = dtWaiterGrid;

        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            sqlConn.MyConnection();
            if (btnAppend.Text == "Append")
            {
                txtWaiterCode.Enabled = true;
                txtWaiterName.Enabled = true;
                txtWAddress.Enabled = true;
                txtWContact.Enabled = true;
                chkActiv.Enabled = true;
                btnAppend.Text = "Save";
                btnUpdate.Text = "Cancel";
                //btnReset.Visible = false;
                txtWaiterCode.Text = null;
                txtWaiterName.Text = null;
                txtWAddress.Text = null;
                txtWContact.Text = null;
                txtWaiterCode.Focus();
            }
            else if (btnAppend.Text == "Save")
            {
                try
                {
                    SqlCommand addWaiter = new SqlCommand("WaiterAdd", sqlConn.sqlCon);
                    addWaiter.CommandType = CommandType.StoredProcedure;
                    addWaiter.Parameters.AddWithValue("@WaiterCode", txtWaiterCode.Text.Trim());
                    addWaiter.Parameters.AddWithValue("@WaiterNam", txtWaiterName.Text.Trim());
                    addWaiter.Parameters.AddWithValue("@WAddress", txtWAddress.Text.Trim());
                    addWaiter.Parameters.AddWithValue("@WContact", txtWContact.Text.Trim());
                    addWaiter.Parameters.AddWithValue("@Activ", chkActiv.Checked);
                    sqlConn.sqlCon.Open();
                    addWaiter.ExecuteNonQuery();
                    ShowWaiterGrid();
                    txtWaiterCode.Text = null;
                    txtWaiterName.Text = null;
                    txtWAddress.Text = null;
                    txtWContact.Text = null;
                    txtWaiterCode.Focus();
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
                try
                {
                    SqlCommand editWaiter = new SqlCommand("WaiterEdit", sqlConn.sqlCon);
                    editWaiter.CommandType = CommandType.StoredProcedure;
                    editWaiter.Parameters.AddWithValue("@WaiterId", mgWaiterId);
                    editWaiter.Parameters.AddWithValue("@WaiterCode", txtWaiterCode.Text.Trim());
                    editWaiter.Parameters.AddWithValue("@WaiterNam", txtWaiterName.Text.Trim());
                    editWaiter.Parameters.AddWithValue("@WAddress", txtWAddress.Text.Trim());
                    editWaiter.Parameters.AddWithValue("@WContact", txtWContact.Text.Trim());
                    editWaiter.Parameters.AddWithValue("@Activ", chkActiv.Checked);
                    sqlConn.sqlCon.Open();
                    editWaiter.ExecuteNonQuery();
                    ShowWaiterGrid();
                    txtWaiterCode.Text = null;
                    txtWaiterName.Text = null;
                    txtWAddress.Text = null;
                    txtWContact.Text = null;
                    txtWaiterCode.Focus();
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
                txtWaiterCode.Text = null;
                txtWaiterName.Text = null;
                txtWAddress.Text = null;
                txtWContact.Text = null;
                txtWaiterCode.Enabled = false;
                txtWaiterName.Enabled = false;
                txtWAddress.Enabled = false;
                txtWContact.Enabled = false;
                chkActiv.Enabled = true;
                btnAppend.Text = "Append";
                btnUpdate.Text = "Exit";
                btnReset.Visible = false;
            }
            else if (btnUpdate.Text == "Exit")
            {
                this.Close();
            }
        }

        private void dgvWaiterList_DoubleClick(object sender, EventArgs e)
        {
            txtWaiterCode.Enabled = true;
            txtWaiterName.Enabled = true;
            txtWAddress.Enabled = true;
            txtWContact.Enabled = true;
            chkActiv.Enabled = true;
            btnAppend.Text = "Update";
            btnUpdate.Text = "Cancel";
            btnReset.Visible = true;


            mgWaiterId = dgvWaiterList.Rows[dgvWaiterList.CurrentRow.Index].Cells["WaiterId"].Value.ToString();
            txtWaiterCode.Text = dgvWaiterList.Rows[dgvWaiterList.CurrentRow.Index].Cells["WaiterCode"].Value.ToString();
            txtWaiterName.Text = dgvWaiterList.Rows[dgvWaiterList.CurrentRow.Index].Cells["WaiterNam"].Value.ToString();
            txtWAddress.Text = dgvWaiterList.Rows[dgvWaiterList.CurrentRow.Index].Cells["WAddress"].Value.ToString();
            txtWContact.Text = dgvWaiterList.Rows[dgvWaiterList.CurrentRow.Index].Cells["WContact"].Value.ToString();

            bool chkActive = (bool)dgvWaiterList.Rows[dgvWaiterList.CurrentRow.Index].Cells["Activ"].Value;
            if (chkActive == true)
            {
                chkActiv.Checked = true;
            }
            else
            {
                chkActiv.Checked = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (btnReset.Text=="Delete")
            {
                try
                {
                    sqlConn.MyConnection();
                    SqlCommand delWaiter = new SqlCommand("WaiterDel", sqlConn.sqlCon);
                    delWaiter.CommandType = CommandType.StoredProcedure;
                    delWaiter.Parameters.AddWithValue("@WaiterId", mgWaiterId);
                    sqlConn.sqlCon.Open();
                    delWaiter.ExecuteNonQuery();
                    ShowWaiterGrid();
                    txtWaiterCode.Text = null;
                    txtWaiterName.Text = null;
                    txtWAddress.Text = null;
                    txtWContact.Text = null;
                    txtWaiterCode.Enabled = false;
                    txtWaiterName.Enabled = false;
                    txtWAddress.Enabled = false;
                    txtWContact.Enabled = false;
                    chkActiv.Enabled = true;
                    btnAppend.Text = "Append";
                    btnUpdate.Text = "Exit";
                    btnReset.Visible = false;
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




    }
}
