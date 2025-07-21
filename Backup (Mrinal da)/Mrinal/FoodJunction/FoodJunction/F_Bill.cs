using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace FoodJunction
{
    public partial class F_Bill : Form
    {
        Global sqlConn = new Global();
        string mfCode;
        float mfTotBill;
        float mfCGST;
        float mfSGST;
        float mfNetAmt;
        float mfAmt;
        float TotBill;
        string mfItemCode;

        public F_Bill()
        {
            InitializeComponent();
            this.dgvBillSub.Columns["Rate"].DefaultCellStyle.Format = "n2";
            this.dgvBillSub.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvBillSub.Columns["Amount"].DefaultCellStyle.Format = "n2";
            this.dgvBillSub.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void F_Bill_Load(object sender, EventArgs e)
        {
            dgvItemShow();
            ComboParty();
            ComboWaiter();
        }


        private void dgvBillSub_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)

        {
            
            GetItem();
        }



        private void dgvBillSub_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            mfTotBill += mfAmt;
            mfCGST = ((mfTotBill * 5) / 100 / 2);
            mfSGST = ((mfTotBill * 5) / 100 / 2);
            mfNetAmt  = mfTotBill + mfCGST + mfSGST;

            Double xC, xS;
            Double xN;


            txtTotBill.Text = mfTotBill.ToString("###,###.00");
            
            txtTotCGST.Text = mfCGST.ToString("###,###.00");
            Double.TryParse(txtTotCGST.Text, out xC);
            txtTotCGST.Text = xC.ToString(".00");

            txtTotSGST.Text = mfSGST.ToString("###,###.00");
            Double.TryParse(txtTotSGST.Text, out xS);
            txtTotSGST.Text = xC.ToString(".00");

            txtNetAmt.Text = mfNetAmt.ToString("N");
            txtNetAmt.Text = Math.Round(decimal.Parse(txtNetAmt.Text),0).ToString("N");
            

            //Double.TryParse(txtNetAmt.Text,out xN);
            //txtNetAmt.Text = Math.Round(xN, MidpointRounding.AwayFromZero); //xN.ToString(".00");
        }

        private void dgvShowItem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //dgvBillSub.Rows[dgvBillSub.CurrentRow.Index].Cells["ItemId"].Value = dgvShowItem.Rows[dgvShowItem.CurrentRow.Index].Cells["ShItmId"].Value.ToString();
                dgvBillSub.Rows[dgvBillSub.CurrentRow.Index].Cells["ItmCode"].Value = dgvShowItem.Rows[dgvShowItem.CurrentRow.Index].Cells["ShItmCode"].Value.ToString();
            sqlConn.MyConnection();
            SqlDataAdapter adGetItem = new SqlDataAdapter();
            DataTable dtGetItem = new DataTable();
            SqlCommand cmdGetItem = new SqlCommand("ItemSelect", sqlConn.sqlCon);
            cmdGetItem.CommandType = CommandType.StoredProcedure;
            cmdGetItem.Parameters.AddWithValue("@ItmCode", dgvBillSub.Rows[dgvBillSub.CurrentRow.Index].Cells["ItmCode"].Value.ToString());
            adGetItem.SelectCommand = cmdGetItem;
            adGetItem.Fill(dtGetItem);

            dgvBillSub.Rows[dgvBillSub.CurrentRow.Index].Cells["ItmDesc"].Value = dtGetItem.Rows[0].Field<string>("ItmNam");
            dgvBillSub.Rows[dgvBillSub.CurrentRow.Index].Cells["Unit"].Value = dtGetItem.Rows[0].Field<string>("ItmUnit");
            dgvBillSub.Rows[dgvBillSub.CurrentRow.Index].Cells["Rate"].Value = dtGetItem.Rows[0].Field<string>("Rate").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConn.sqlCon.State == ConnectionState.Open)
                {
                    sqlConn.sqlCon.Close();

                }

            }
            dgvBillSub.Focus();
        }


        //------------------------------------------------------------------
        #region All Function

        public void dgvItemShow()  // Set All Data to GridView from Table
        {
            sqlConn.MyConnection();
            SqlDataAdapter adItemList = new SqlDataAdapter();
            DataTable dtIetmList = new DataTable();
            SqlCommand cmdItemList = new SqlCommand("ItemList", sqlConn.sqlCon);
            cmdItemList.CommandType = CommandType.StoredProcedure;
            adItemList.SelectCommand = cmdItemList;
            adItemList.Fill(dtIetmList);
            dgvShowItem.AutoGenerateColumns = false;
            dgvShowItem.DataSource = dtIetmList;
            sqlConn.sqlCon.Close();
        }

        public void ComboWaiter() // Set Category ComboBox Data from Table 
        {
            sqlConn.MyConnection();
            SqlDataAdapter adCombWaiter = new SqlDataAdapter();
            DataSet dsCombWaiter = new DataSet();
            SqlCommand cmdCombWaiter = new SqlCommand("WaiterList", sqlConn.sqlCon);
            cmdCombWaiter.CommandType = CommandType.StoredProcedure;
            adCombWaiter.SelectCommand = cmdCombWaiter;
            adCombWaiter.Fill(dsCombWaiter);
            cmbWaiter.ValueMember = "WaiterID";
            cmbWaiter.DisplayMember = "WaiterNam";
            cmbWaiter.DataSource = dsCombWaiter.Tables[0];
            sqlConn.sqlCon.Close();
        }

        public void ComboParty() // Set Category ComboBox Data from Table 
        {
            sqlConn.MyConnection();
            SqlDataAdapter adCombGrp = new SqlDataAdapter();
            DataSet dsCombGrop = new DataSet();
            SqlCommand cmdCombGrp = new SqlCommand("PartyListAll", sqlConn.sqlCon);
            cmdCombGrp.CommandType = CommandType.StoredProcedure;
            adCombGrp.SelectCommand = cmdCombGrp;
            adCombGrp.Fill(dsCombGrop);
            cmbParty.ValueMember = "PartyId";
            cmbParty.DisplayMember = "PName";
            cmbParty.DataSource = dsCombGrop.Tables[0];
            sqlConn.sqlCon.Close();
        }

        public void GetItem()
        {
            //int col = dgvBillSub.CurrentCell.ColumnIndex;
            //int row = dgvBillSub.CurrentCell.RowIndex;

            int i;
            for (i = 0; i < dgvBillSub.Rows.Count - 1 ; i++)
            {
                try
                {
                    sqlConn.MyConnection();
                    SqlDataAdapter adGetItem = new SqlDataAdapter();
                    DataTable dtGetItem = new DataTable();
                    SqlCommand cmdGetItem = new SqlCommand("ItemSelect", sqlConn.sqlCon);
                    cmdGetItem.CommandType = CommandType.StoredProcedure;
                    cmdGetItem.Parameters.AddWithValue("@ItmCode", dgvBillSub.Rows[i].Cells["ItmCode"].Value.ToString());
                    adGetItem.SelectCommand = cmdGetItem;
                    adGetItem.Fill(dtGetItem);

                    dgvBillSub.Rows[i].Cells["ItmDesc"].Value = dtGetItem.Rows[0].Field<string>("ItmNam");
                    dgvBillSub.Rows[i].Cells["Unit"].Value = dtGetItem.Rows[0].Field<string>("ItmUnit");
                    dgvBillSub.Rows[i].Cells["Rate"].Value = dtGetItem.Rows[0].Field<string>("Rate").ToString();
                    //dgvBillSub.CurrentCell = dgvBillSub.Rows[i].Cells["Qty"];

                    int mfQty = Convert.ToInt32(dgvBillSub.Rows[i].Cells["Qty"].Value);
                    int mfRate = Convert.ToInt32(dgvBillSub.Rows[i].Cells["Rate"].Value);
                    mfAmt = mfQty * mfRate;
                    dgvBillSub.Rows[i].Cells["Amount"].Value = mfAmt;
                    //                    dgvBillSub.CurrentCell = dgvBillSub[dgvBillSub.CurrentCell.ColumnIndex + 1, dgvBillSub.CurrentCell.RowIndex].Selected=true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

  
            }

        }




        #endregion

 
    }
}
