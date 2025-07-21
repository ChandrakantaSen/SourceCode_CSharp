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
    public partial class F_ItemMaster : Form
    {
//----------------------------------------------------------------------------------------------------------------------------------------------
        Global sqlConn = new Global();
        //SqlConnection Conn = new SqlConnection(@"Data Source = localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");
        string mgItmId;

        public F_ItemMaster()
        {
            InitializeComponent();
        }

        #region Function for DataGridView & ComboBox

        public void dgvItemShow()  // Set All Data to GridView from Table
        {
            sqlConn.MyConnection();
            SqlDataAdapter adItemList = new SqlDataAdapter();
            DataTable dtIetmList = new DataTable();
            SqlCommand cmdItemList = new SqlCommand("ItemList", sqlConn.sqlCon);
            cmdItemList.CommandType = CommandType.StoredProcedure;
            adItemList.SelectCommand = cmdItemList;
            adItemList.Fill(dtIetmList);
            dgvItemList.AutoGenerateColumns = false;
            dgvItemList.DataSource = dtIetmList;
            sqlConn.sqlCon.Close();

        }


        public void dgvItemShowFilter()  // Set All Data to GridView from Table
        {
            sqlConn.MyConnection();
            SqlDataAdapter adItemListFilter = new SqlDataAdapter();
            DataTable dtIetmListFilter = new DataTable();
            SqlCommand cmddgvGrpFilter = new SqlCommand("ItemListFilter", sqlConn.sqlCon);
            cmddgvGrpFilter.CommandType = CommandType.StoredProcedure;
            cmddgvGrpFilter.Parameters.AddWithValue("@SearchFilter", txtSearch.Text.Trim());
            adItemListFilter.SelectCommand = cmddgvGrpFilter;
            adItemListFilter.Fill(dtIetmListFilter);
            dgvItemList.AutoGenerateColumns = false;
            dgvItemList.DataSource = dtIetmListFilter;
            sqlConn.sqlCon.Close();

        }



        public void ComboGrp() // Set Category ComboBox Data from Table 
        {
            sqlConn.MyConnection();
            SqlDataAdapter adCombGrp = new SqlDataAdapter();
            DataSet dsCombGrop = new DataSet();
            SqlCommand cmdCombGrp = new SqlCommand("GrpList", sqlConn.sqlCon);
            cmdCombGrp.CommandType = CommandType.StoredProcedure;
            adCombGrp.SelectCommand = cmdCombGrp;
            adCombGrp.Fill(dsCombGrop);
            cmbGrp.ValueMember = "GrpId";
            cmbGrp.DisplayMember = "GrpDesc";
            cmbGrp.DataSource=dsCombGrop.Tables[0];
            sqlConn.sqlCon.Close();
        }

        public void ComboTax() // Set Tax ComboBox Data from Table
        {
            sqlConn.MyConnection();
            SqlDataAdapter adCombTax = new SqlDataAdapter();
            DataSet dsCombGrop = new DataSet();
            SqlCommand cmdCombGrp = new SqlCommand("TaxList", sqlConn.sqlCon);
            cmdCombGrp.CommandType = CommandType.StoredProcedure;
            adCombTax.SelectCommand = cmdCombGrp;
            adCombTax.Fill(dsCombGrop);
            cmbTax.ValueMember = "TaxId";
            cmbTax.DisplayMember = "TaxDesc";
            cmbTax.DataSource = dsCombGrop.Tables[0];
            sqlConn.sqlCon.Close();
        }

        public void ComboUnit() // Set Tax ComboBox Data from Table
        {
            sqlConn.MyConnection();
            SqlDataAdapter adCombUnit = new SqlDataAdapter();
            DataSet dsCombUnit = new DataSet();
            SqlCommand cmdCombUnit = new SqlCommand("ItmUnitList", sqlConn.sqlCon);
            cmdCombUnit.CommandType = CommandType.StoredProcedure;
            adCombUnit.SelectCommand = cmdCombUnit;
            adCombUnit.Fill(dsCombUnit);
            cmbUnit.ValueMember = "ItmUnit";
            cmbUnit.DisplayMember = "ItmUnit";
            cmbUnit.DataSource = dsCombUnit.Tables[0];
            sqlConn.sqlCon.Close();
        }


        #endregion

        private void F_ItemMaster_Load(object sender, EventArgs e)
        {
            dgvItemShow();
            ComboGrp();
            ComboTax();
            ComboUnit();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (btnAppend.Text == "Append")
            {
                txtItmCode.Enabled = true;
                txtItmName.Enabled = true;
                txtItmSName.Enabled = true;
                cmbGrp.Enabled = true;
                txtItmPrice.Enabled = true;
                cmbTax.Enabled = true;
                cmbUnit.Enabled = true;
                txtItmDesc.Enabled = true;

                btnAppend.Text = "Save";
                btnUpdate.Text = "Cancel";
                //btnReset.Visible = false;
                
                txtItmCode.Text = null;
                txtItmName.Text = null;
                txtItmSName.Text = null;
                cmbGrp.Refresh();
                txtItmPrice.Text = null;
                cmbTax.Refresh();
                txtItmCode.Focus();
            }
            else if (btnAppend.Text == "Save")
            {
                try
                {
                    sqlConn.MyConnection();
                    SqlCommand addItem = new SqlCommand("ItemAdd", sqlConn.sqlCon);
                    addItem.CommandType = CommandType.StoredProcedure;
                    addItem.Parameters.AddWithValue("@ItmCode", txtItmCode.Text.Trim());
                    addItem.Parameters.AddWithValue("@ItmNam", txtItmName.Text.Trim());
                    addItem.Parameters.AddWithValue("@ItmPrice", Convert.ToDecimal(txtItmPrice.Text).ToString());
                    addItem.Parameters.AddWithValue("@ItmShotNam", txtItmSName.Text.Trim());
                    addItem.Parameters.AddWithValue("@GrpId", (int.Parse(cmbGrp.SelectedValue.ToString())));
                    addItem.Parameters.AddWithValue("@TaxId", (int.Parse(cmbTax.SelectedValue.ToString())));
                    addItem.Parameters.AddWithValue("@ItemImg", txtItmImgPath.Text.Trim());
                    addItem.Parameters.AddWithValue("@ItmUnit", cmbUnit.Text.Trim());
                    addItem.Parameters.AddWithValue("@ItmDesc", txtItmDesc.Text.Trim());
                    sqlConn.sqlCon.Open();
                    addItem.ExecuteNonQuery();
                    dgvItemShow();
                    txtItmCode.Text = null;
                    txtItmName.Text = null;
                    txtItmSName.Text = null;
                    cmbGrp.Refresh();
                    txtItmPrice.Text = null;
                    cmbTax.Refresh(); 
                    txtItmCode.Focus();
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
                    SqlCommand editItem = new SqlCommand("ItemEdit", sqlConn.sqlCon);
                    editItem.CommandType = CommandType.StoredProcedure;
                    editItem.Parameters.AddWithValue("@ItmId", mgItmId);
                    editItem.Parameters.AddWithValue("@ItmCode", txtItmCode.Text.Trim());
                    editItem.Parameters.AddWithValue("@ItmNam", txtItmName.Text.Trim());
                    editItem.Parameters.AddWithValue("@ItmPrice", Convert.ToDecimal(txtItmPrice.Text).ToString());
                    editItem.Parameters.AddWithValue("@ItmShotNam", txtItmSName.Text.Trim());
                    editItem.Parameters.AddWithValue("@GrpId", (int.Parse(cmbGrp.SelectedValue.ToString())));
                    editItem.Parameters.AddWithValue("@TaxId", (int.Parse(cmbTax.SelectedValue.ToString())));
                    editItem.Parameters.AddWithValue("@ItemImg", txtItmImgPath.Text.Trim());
                    editItem.Parameters.AddWithValue("@ItmUnit", cmbUnit.Text.Trim());
                    editItem.Parameters.AddWithValue("@ItmDesc", txtItmDesc.Text.Trim());
                    sqlConn.sqlCon.Open();
                    editItem.ExecuteNonQuery();
                    dgvItemShow();
                    txtItmCode.Text = null;
                    txtItmName.Text = null;
                    txtItmSName.Text = null;
                    cmbGrp.Refresh();
                    txtItmPrice.Text = null;
                    cmbTax.Refresh();
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
                txtItmCode.Text = null;
                txtItmName.Text = null;
                txtItmSName.Text = null;
                cmbGrp.Refresh();
                txtItmPrice.Text = null;
                cmbTax.Refresh();
                txtItmImgPath.Text = null;
                pbxtem.Image = null;
                pbxtem.BackgroundImage = new Bitmap("D:\\Enfotech\\MisResto\\FoodJunction\\FoodJunction\\Images\\NoImage.jpg");
                pbxtem.BackgroundImageLayout=ImageLayout.Stretch;
                txtItmCode.Enabled = false;
                txtItmName.Enabled = false;
                txtItmSName.Enabled = false;
                cmbGrp.Enabled = false;
                txtItmPrice.Enabled = false;
                cmbTax.Enabled = false;
                cmbUnit.Enabled = false;
                txtItmDesc.Enabled = false;

                
                btnAppend.Text = "Append";
                btnUpdate.Text = "Exit";
                btnReset.Visible = false;
            }
            else if (btnUpdate.Text == "Exit")
            {
                this.Close();
            }
        }


        #region Fetch data & Image from Dridview to Field 

        private void dgvItemList_DoubleClick(object sender, EventArgs e)
        {
            txtItmCode.Enabled = true;
            txtItmName.Enabled = true;
            txtItmSName.Enabled = true;
            cmbGrp.Enabled = true;
            txtItmPrice.Enabled = true;
            cmbTax.Enabled = true;
            cmbUnit.Enabled = true;
            txtItmDesc.Enabled = true;

            btnAppend.Text = "Update";
            btnUpdate.Text = "Cancel";
            btnReset.Visible = true;


            mgItmId = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmId"].Value.ToString();
            txtItmCode.Text = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmCode"].Value.ToString();
            txtItmName.Text = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmNam"].Value.ToString();
            txtItmSName.Text = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmShotNam"].Value.ToString();
            txtItmPrice.Text = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmPrice"].Value.ToString();
            cmbGrp.SelectedValue = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["GrpId"].Value.ToString();
            cmbTax.SelectedValue = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["TaxId"].Value.ToString();
            txtItmImgPath.Text = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItemImg"].Value.ToString();
            cmbUnit.Text=dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmUnit"].Value.ToString();
            txtItmDesc.Text = dgvItemList.Rows[dgvItemList.CurrentRow.Index].Cells["ItmDesc"].Value.ToString();

            if (txtItmImgPath.Text!="")
            {
            pbxtem.BackgroundImage = null;
            pbxtem.Image = new Bitmap(txtItmImgPath.Text);
            pbxtem.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        #endregion

        #region Select or Change Image at Picture Box using OpenFileDialog (Windows Open Browser)

        private void pbxtem_DoubleClick(object sender, EventArgs e)
        {
            if (txtItmCode.Text!= "" || !string.IsNullOrEmpty(txtItmCode.Text))
            {

            OpenFileDialog itmImageBrowser = new OpenFileDialog();
            itmImageBrowser.InitialDirectory = "C:\\";
            itmImageBrowser.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|All Files(*.*)|*.*";
            itmImageBrowser.FilterIndex = 1;
            //itmImageBrowser.ShowDialog();
            if (itmImageBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                //Copy Image from Original Path to Destination Path - Method - I
                //System.IO.File.Copy(itmImageBrowser.FileName, @"D:\Enfotech\MisResto\FoodJunction\FoodJunction\Images\" + txtItmCode.Text.Trim() + ".jpg",true);

                //Copy Image from Original Path to Destination Path - Method - II

                string appPath = Application.StartupPath;
                string ImagePath = appPath.Substring(0, (appPath.Length - 10));
                string ImgFileExtention = System.IO.Path.GetExtension(itmImageBrowser.FileName);
                string savePath = ImagePath + "\\Images\\" + txtItmCode.Text.Trim() + ImgFileExtention;
                System.IO.File.Copy(itmImageBrowser.FileName, savePath,true);
                txtItmImgPath.Text = savePath;
                pbxtem.BackgroundImage = null;
                pbxtem.Image = new Bitmap(savePath);
                pbxtem.SizeMode = PictureBoxSizeMode.StretchImage;

            
            }
            }
            else
            {
                MessageBox.Show("Item Code required");

            }

        }

        #endregion


        #region Make the textbox only for Decimal Value

        private void txtItmPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtItmPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled=true;
            }
        }

        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvItemShowFilter();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvItemShow();
        }

        private void cmbUnit_DropDown(object sender, EventArgs e)
        {
            ComboUnit();
        }




        //----------------------------------------------------------------------------------------------------------------------------------------------
    }
}
