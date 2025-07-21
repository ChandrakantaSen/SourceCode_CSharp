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
    public partial class F_Category : Form
    {
        Global sqlConn = new Global();
        //SqlConnection Conn = new SqlConnection(@"Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");

       string mgGrpId;

        public F_Category()
        {
            InitializeComponent();
        }



        public void dgvGroupListShow()
        {
            sqlConn.MyConnection();
            SqlDataAdapter adGrList = new SqlDataAdapter();
            DataTable dtGrList = new DataTable();

            SqlCommand cmdGRList = new SqlCommand("GrpList", sqlConn.sqlCon);
            cmdGRList.CommandType = CommandType.StoredProcedure;
            adGrList.SelectCommand = cmdGRList;
            adGrList.Fill(dtGrList);
            dgvGrpList.AutoGenerateColumns = false;
            dgvGrpList.DataSource = dtGrList;

        }

        private void F_Category_Load(object sender, EventArgs e)
        {
            dgvGroupListShow();
        }

        #region Button Append -  btnAdd
        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (btnAppend.Text == "Append")
            {
                txtGCode.Enabled = true;
                txtGDesc.Enabled = true;
                btnAppend.Text = "Save";
                btnUpdate.Text = "Cancel";
                //btnReset.Visible = false;
                txtGCode.Text = null;
                txtGDesc.Text = null;
                txtGCode.Focus();
            }
            else if (btnAppend.Text == "Save")
            {
                try
                {
                    sqlConn.MyConnection();
                    SqlCommand addGrp = new SqlCommand("GrpAdd", sqlConn.sqlCon);
                    addGrp.CommandType = CommandType.StoredProcedure;
                    addGrp.Parameters.AddWithValue("@GrpCode", txtGCode.Text.Trim());
                    addGrp.Parameters.AddWithValue("@GrpDesc", txtGDesc.Text.Trim());
                    sqlConn.sqlCon.Open();
                    addGrp.ExecuteNonQuery();
                    dgvGroupListShow();
                    txtGCode.Text = null;
                    txtGDesc.Text = null;
                    txtGCode.Focus();
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
                    sqlConn.MyConnection();
                    SqlCommand editGrp = new SqlCommand("GrpEdit", sqlConn.sqlCon);
                    editGrp.CommandType = CommandType.StoredProcedure;
                    editGrp.Parameters.AddWithValue("@GrpId", mgGrpId);
                    editGrp.Parameters.AddWithValue("@GrpCode", txtGCode.Text.Trim());
                    editGrp.Parameters.AddWithValue("@GrpDesc", txtGDesc.Text.Trim());
                    sqlConn.sqlCon.Open();
                    editGrp.ExecuteNonQuery();
                    dgvGroupListShow();
                    txtGCode.Text = null;
                    txtGDesc.Text = null;
                    txtGCode.Focus();
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

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Cancel")
            {
                txtGCode.Text = null;
                txtGDesc.Text = null;
                txtGCode.Enabled = false;
                txtGDesc.Enabled = false;
                btnAppend.Text = "Append";
                btnUpdate.Text = "Exit";
                btnReset.Visible = false;
            }
            else if (btnUpdate.Text == "Exit")
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.MyConnection();
                SqlCommand delGrp = new SqlCommand("GrpDel", sqlConn.sqlCon);
                delGrp.CommandType = CommandType.StoredProcedure;
                delGrp.Parameters.AddWithValue("@GrpId", mgGrpId);
                sqlConn.sqlCon.Open();
                delGrp.ExecuteNonQuery();
                dgvGroupListShow();

                txtGCode.Text = null;
                txtGDesc.Text = null;
                txtGCode.Enabled = false;
                txtGDesc.Enabled = false;
                btnAppend.Text = "Append";
                btnUpdate.Text = "Exit";
                btnReset.Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problem in Delete", ex.Message);
            }

            finally
            {
                if (sqlConn.sqlCon.State == ConnectionState.Open)
                {
                    sqlConn.sqlCon.Close();
                }

            }

        }

        private void dgvGrpList_DoubleClick(object sender, EventArgs e)
        {
            txtGCode.Enabled = true;
            txtGDesc.Enabled = true;
            btnAppend.Text = "Update";
            btnUpdate.Text = "Cancel";
            btnReset.Visible = true;
            mgGrpId = dgvGrpList.Rows[dgvGrpList.CurrentRow.Index].Cells["GrpID"].Value.ToString();
            txtGCode.Text = dgvGrpList.Rows[dgvGrpList.CurrentRow.Index].Cells["GrpCode"].Value.ToString();
            txtGDesc.Text = dgvGrpList.Rows[dgvGrpList.CurrentRow.Index].Cells["GrpDesc"].Value.ToString();
            txtGCode.Focus();
        }

    }
}
