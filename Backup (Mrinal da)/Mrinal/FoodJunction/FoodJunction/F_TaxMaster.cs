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
    public partial class F_TaxMaster : Form
    {

        Global sqlConn = new Global();
        //SqlConnection Conn = new SqlConnection(@"Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");
        string mgTaxId;


        public F_TaxMaster()
        {
            InitializeComponent();
        }


        public void dgvGroupListShow()
        {
            sqlConn.MyConnection();
            SqlDataAdapter adTaxList = new SqlDataAdapter();
            DataTable dtGrList = new DataTable();

            SqlCommand cmdGRList = new SqlCommand("TaxList", sqlConn.sqlCon);
            cmdGRList.CommandType = CommandType.StoredProcedure;
            adTaxList.SelectCommand = cmdGRList;
            adTaxList.Fill(dtGrList);
            dgvTaxList.AutoGenerateColumns = false;
            dgvTaxList.DataSource = dtGrList;

        }

        private void F_TaxMaster_Load(object sender, EventArgs e)
        {
            dgvGroupListShow();
        }

        #region Button Append -  btnAdd
        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (btnAppend.Text == "Append")
            {
                txtHSNCode.Enabled = true;
                txtTRate.Enabled = true;
                btnAppend.Text = "Save";
                btnUpdate.Text = "Cancel";
                //btnReset.Visible = true;
                txtHSNCode.Text = null;
                txtTRate.Text = null;
                txtHSNCode.Focus();
            }
            else if (btnAppend.Text == "Save")
            {
                try
                {
                    sqlConn.MyConnection();
                    SqlCommand addTax = new SqlCommand("TaxAdd", sqlConn.sqlCon);
                    addTax.CommandType = CommandType.StoredProcedure;
                    addTax.Parameters.AddWithValue("@HSNCode", txtHSNCode.Text.Trim());
                    addTax.Parameters.AddWithValue("@TRate", (int.Parse(txtTRate.Text)));
                    sqlConn.sqlCon.Open();
                    addTax.ExecuteNonQuery();
                    dgvGroupListShow();
                    txtHSNCode.Text = null;
                    txtTRate.Text = null;
                    txtHSNCode.Focus();
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
                    SqlCommand editTax = new SqlCommand("TaxEdit", sqlConn.sqlCon);
                    editTax.CommandType = CommandType.StoredProcedure;
                    editTax.Parameters.AddWithValue("@TaxId", mgTaxId);
                    editTax.Parameters.AddWithValue("@HSNCode", txtHSNCode.Text.Trim());
                    editTax.Parameters.AddWithValue("@TRate", txtTRate.Text.Trim());
                    sqlConn.sqlCon.Open();
                    editTax.ExecuteNonQuery();
                    dgvGroupListShow();
                    txtHSNCode.Text = null;
                    txtTRate.Text = null;
                    txtHSNCode.Focus();
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
                txtHSNCode.Text = null;
                txtTRate.Text = null;
                txtHSNCode.Enabled = false;
                txtTRate.Enabled = false;
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
                SqlCommand delTax = new SqlCommand("TaxDel", sqlConn.sqlCon);
                delTax.CommandType = CommandType.StoredProcedure;
                delTax.Parameters.AddWithValue("@TaxId", mgTaxId);
                sqlConn.sqlCon.Open();
                delTax.ExecuteNonQuery();
                dgvGroupListShow();

                txtHSNCode.Text = null;
                txtTRate.Text = null;
                txtHSNCode.Enabled = false;
                txtTRate.Enabled = false;
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

        private void dgvTaxList_DoubleClick(object sender, EventArgs e)
        {
            txtHSNCode.Enabled = true;
            txtTRate.Enabled = true;
            btnAppend.Text = "Update";
            btnUpdate.Text = "Cancel";
            btnReset.Visible = true;
            mgTaxId = dgvTaxList.Rows[dgvTaxList.CurrentRow.Index].Cells["TaxID"].Value.ToString();
            txtHSNCode.Text = dgvTaxList.Rows[dgvTaxList.CurrentRow.Index].Cells["HSNCode"].Value.ToString();
            txtTRate.Text = dgvTaxList.Rows[dgvTaxList.CurrentRow.Index].Cells["TRate"].Value.ToString();
            txtHSNCode.Focus();
        }


        #region Numeric textbox : Ignor Alphabat / % / and more that one .(dot)

        private void txtTRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtTRate.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (ch == 37 ) //&& txtTRate.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }

        #endregion

    }
}
