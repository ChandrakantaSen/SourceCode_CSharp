using System;
using System.Drawing;
using System.Windows.Forms;

//using for accessing a form inside the folder
using Project001.App_Tenant;
using Project001.App_Customer;

namespace Project001
{
	public partial class HomePage : Form
	{
		public HomePage()
		{
			InitializeComponent();
		}
		
		void HomePage_Load(object sender, EventArgs e)
		{
			IsMdiContainer = true;
		}
		
		void TenantToolStripMenuItem_Click(object sender, EventArgs e)
		{   
			Tenant tntObj = new Tenant();
			tntObj.Dock = DockStyle.Fill;
			tntObj.Show();
			tntObj.MdiParent = this;
		}

		//Add Customer Section
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustObj = new AddCustomer();
            addCustObj.Dock = DockStyle.Fill;
            addCustObj.Show();
            addCustObj.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}

		//View Customer Section
		private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewCustomer viewCustObj = new ViewCustomer();
			viewCustObj.Dock = DockStyle.Fill;
			viewCustObj.Show();
			viewCustObj.MdiParent = this;
		}

		private void salesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void vendorManagementToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}