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
    public partial class OpScreen : Form
    {
        private int childFormNumber = 0;
        private string p;
        private string Per;

        string menuStr;

        SqlConnection Conn = new SqlConnection(@"Data Source =localhost;Initial Catalog=FoodJunction;User Id=sa;Password=dasmondal");

        public OpScreen(string P)  // P hold the User Name to from Login screen
        {
            InitializeComponent();
            lblstatusUserName.Text  = "Welcome User :  " + P;

        }

        private void OpScreen_Load(object sender, EventArgs e)
        {
            
            restMenu();
        }

 
        private void restMenu()
        {

                string SQLStr;
                SQLStr = "SELECT permissions FROM T_UserPermission where ID=" + F_Login.GroupId;
                SqlDataAdapter DA = new SqlDataAdapter(SQLStr, Conn);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                menuStr = DS.Tables[0].Rows[0][0].ToString();

                string MenuSQLStr;
                MenuSQLStr = "SELECT MenuId, MenuName, ParentId FROM T_RestaruntMenu where MenuID in (" + menuStr + ")";
                SqlDataAdapter menuDA = new SqlDataAdapter(MenuSQLStr, Conn);
                DataSet menuDS = new DataSet();
                menuDA.Fill(menuDS);

                DataTable mTable = new DataTable();
                mTable = menuDS.Tables[0];
                DataView mView = new DataView(mTable);
                mView.RowFilter = "ParentID=0";

                foreach (DataRowView row in mView)
                {
                    foreach (ToolStripMenuItem item in menuStrip.Items)
                    {
                        if(row["MenuName"].ToString()==item.Name)
                        {
                            item.Visible = true;
                        }

                        AddChildForms(mTable, row["MenuId"].ToString(), item);

                    }

                }

        }

    private void AddChildForms(DataTable vcTable, string vcID, ToolStripMenuItem vcItem)
        {
            DataView ViewChild = new DataView(vcTable);
            ViewChild.RowFilter = "ParentId=" + vcID;

            foreach (DataRowView ChildViewItem in ViewChild)
            {
                foreach (ToolStripMenuItem item in vcItem.DropDownItems)
                {
                    if (ChildViewItem["MenuName"].ToString() == item.Name)
                    {
                        item.Visible = true;
                    }

                    AddChildForms(vcTable, ChildViewItem["MenuId"].ToString(), item);

                }
            }

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You want to Exit","Exit Form", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

//------------  Display date and time at statusStrip bar ---------------------------------------------------
//---  Add item collection at statusStrip and add statusLable , set name----------
                
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy    hh:mm:ss tt");
        }

        private void menuTableMaster_Click(object sender, EventArgs e)
        {
            F_Table childTable = new F_Table();
            childTable.MdiParent = this;
            childTable.Show();
        }

        private void menuWaiterMaster_Click(object sender, EventArgs e)
        {
            F_Waiter childWaiter = new F_Waiter();
            childWaiter.MdiParent = this;
            childWaiter.Show();

        }

        private void menuCategoryMaster_Click(object sender, EventArgs e)
        {
            F_Category childCategory = new F_Category();
            childCategory.MdiParent = this;
            childCategory.Show();

        }

        private void menuTaxMaster_Click(object sender, EventArgs e)
        {
            F_TaxMaster childTax = new F_TaxMaster();
            childTax.MdiParent = this;
            childTax.Show();
        }

        private void menuItemMas_Click(object sender, EventArgs e)
        {
            F_ItemMaster childItemMas = new F_ItemMaster();
            childItemMas.MdiParent = this;
            childItemMas.Show();
        }

        private void menuBill_Click(object sender, EventArgs e)
        {
            F_Bill childBill = new F_Bill();
            childBill.MdiParent = this;
            childBill.Show();

        }

        private void menuCustomerMaster_Click(object sender, EventArgs e)
        {
            F_Party childParty = new F_Party();
            childParty.MdiParent=this;
            childParty.Show();
        }

//----------------------------------------------------------------------------------------------------------
       

    }

   
}
