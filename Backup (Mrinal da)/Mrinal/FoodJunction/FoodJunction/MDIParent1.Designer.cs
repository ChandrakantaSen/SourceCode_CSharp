namespace FoodJunction
{
    partial class OpScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.mtManagerRes = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagemntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTableMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWaiterMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMas = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaxMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBill = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billRegistrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblstatusUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Admin,
            this.transactionToolStripMenuItem,
            this.transactionToolStripMenuItem1,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1247, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtManagerRes,
            this.userManagemntToolStripMenuItem,
            this.menuExit});
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(59, 21);
            this.Admin.Text = "Admin";
            // 
            // mtManagerRes
            // 
            this.mtManagerRes.Image = global::FoodJunction.Properties.Resources.RocketDock;
            this.mtManagerRes.Name = "mtManagerRes";
            this.mtManagerRes.Size = new System.Drawing.Size(197, 22);
            this.mtManagerRes.Text = "Manager Restaurent";
            // 
            // userManagemntToolStripMenuItem
            // 
            this.userManagemntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGroupToolStripMenuItem,
            this.setPermissionToolStripMenuItem,
            this.userMasterToolStripMenuItem});
            this.userManagemntToolStripMenuItem.Image = global::FoodJunction.Properties.Resources.WLM;
            this.userManagemntToolStripMenuItem.Name = "userManagemntToolStripMenuItem";
            this.userManagemntToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.userManagemntToolStripMenuItem.Text = "User Managemnt";
            // 
            // userGroupToolStripMenuItem
            // 
            this.userGroupToolStripMenuItem.Image = global::FoodJunction.Properties.Resources.People;
            this.userGroupToolStripMenuItem.Name = "userGroupToolStripMenuItem";
            this.userGroupToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userGroupToolStripMenuItem.Text = "User Group";
            // 
            // setPermissionToolStripMenuItem
            // 
            this.setPermissionToolStripMenuItem.Image = global::FoodJunction.Properties.Resources.Person_group_warning;
            this.setPermissionToolStripMenuItem.Name = "setPermissionToolStripMenuItem";
            this.setPermissionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.setPermissionToolStripMenuItem.Text = "Set Permission";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Image = global::FoodJunction.Properties.Resources.User1;
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userMasterToolStripMenuItem.Text = "User Master";
            // 
            // menuExit
            // 
            this.menuExit.Image = global::FoodJunction.Properties.Resources.X;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(197, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTableMaster,
            this.menuWaiterMaster,
            this.itemToolStripMenuItem,
            this.priceToolStripMenuItem,
            this.menuCustomerMaster,
            this.menuTaxMaster});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.transactionToolStripMenuItem.Text = "Master";
            // 
            // menuTableMaster
            // 
            this.menuTableMaster.Image = global::FoodJunction.Properties.Resources.Packed;
            this.menuTableMaster.Name = "menuTableMaster";
            this.menuTableMaster.Size = new System.Drawing.Size(152, 22);
            this.menuTableMaster.Text = "Table";
            this.menuTableMaster.Click += new System.EventHandler(this.menuTableMaster_Click);
            // 
            // menuWaiterMaster
            // 
            this.menuWaiterMaster.Image = global::FoodJunction.Properties.Resources.lj_user_v2;
            this.menuWaiterMaster.Name = "menuWaiterMaster";
            this.menuWaiterMaster.Size = new System.Drawing.Size(152, 22);
            this.menuWaiterMaster.Text = "Waiter";
            this.menuWaiterMaster.Click += new System.EventHandler(this.menuWaiterMaster_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoryMaster,
            this.menuItemMas});
            this.itemToolStripMenuItem.Image = global::FoodJunction.Properties.Resources.Paper_pencil;
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // menuCategoryMaster
            // 
            this.menuCategoryMaster.Name = "menuCategoryMaster";
            this.menuCategoryMaster.Size = new System.Drawing.Size(149, 22);
            this.menuCategoryMaster.Text = "Category";
            this.menuCategoryMaster.Click += new System.EventHandler(this.menuCategoryMaster_Click);
            // 
            // menuItemMas
            // 
            this.menuItemMas.Name = "menuItemMas";
            this.menuItemMas.Size = new System.Drawing.Size(149, 22);
            this.menuItemMas.Text = "Item Master";
            this.menuItemMas.Click += new System.EventHandler(this.menuItemMas_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceMasterToolStripMenuItem,
            this.priceSetupToolStripMenuItem});
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.priceToolStripMenuItem.Text = "Price";
            // 
            // priceMasterToolStripMenuItem
            // 
            this.priceMasterToolStripMenuItem.Name = "priceMasterToolStripMenuItem";
            this.priceMasterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.priceMasterToolStripMenuItem.Text = "Price Master";
            // 
            // priceSetupToolStripMenuItem
            // 
            this.priceSetupToolStripMenuItem.Name = "priceSetupToolStripMenuItem";
            this.priceSetupToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.priceSetupToolStripMenuItem.Text = "Price Setup";
            // 
            // menuCustomerMaster
            // 
            this.menuCustomerMaster.Name = "menuCustomerMaster";
            this.menuCustomerMaster.Size = new System.Drawing.Size(152, 22);
            this.menuCustomerMaster.Text = "Customer";
            this.menuCustomerMaster.Click += new System.EventHandler(this.menuCustomerMaster_Click);
            // 
            // menuTaxMaster
            // 
            this.menuTaxMaster.Name = "menuTaxMaster";
            this.menuTaxMaster.Size = new System.Drawing.Size(152, 22);
            this.menuTaxMaster.Text = "Tax Master";
            this.menuTaxMaster.Click += new System.EventHandler(this.menuTaxMaster_Click);
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBill,
            this.deliveryToolStripMenuItem});
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(88, 21);
            this.transactionToolStripMenuItem1.Text = "Transaction";
            // 
            // menuBill
            // 
            this.menuBill.Name = "menuBill";
            this.menuBill.Size = new System.Drawing.Size(126, 22);
            this.menuBill.Text = "Bills";
            this.menuBill.Click += new System.EventHandler(this.menuBill_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegToolStripMenuItem,
            this.billRegistrarToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customerRegToolStripMenuItem
            // 
            this.customerRegToolStripMenuItem.Name = "customerRegToolStripMenuItem";
            this.customerRegToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.customerRegToolStripMenuItem.Text = "Customer Reg.";
            // 
            // billRegistrarToolStripMenuItem
            // 
            this.billRegistrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemWiseToolStripMenuItem,
            this.billWiseToolStripMenuItem});
            this.billRegistrarToolStripMenuItem.Name = "billRegistrarToolStripMenuItem";
            this.billRegistrarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.billRegistrarToolStripMenuItem.Text = "Registrar";
            // 
            // itemWiseToolStripMenuItem
            // 
            this.itemWiseToolStripMenuItem.Name = "itemWiseToolStripMenuItem";
            this.itemWiseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.itemWiseToolStripMenuItem.Text = "Item wise";
            // 
            // billWiseToolStripMenuItem
            // 
            this.billWiseToolStripMenuItem.Name = "billWiseToolStripMenuItem";
            this.billWiseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.billWiseToolStripMenuItem.Text = "Bill Wise";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatusUserName,
            this.lblStatusTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1247, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblstatusUserName
            // 
            this.lblstatusUserName.Name = "lblstatusUserName";
            this.lblstatusUserName.Size = new System.Drawing.Size(72, 17);
            this.lblstatusUserName.Text = "lbUserStatus";
            // 
            // lblStatusTime
            // 
            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(118, 17);
            this.lblStatusTime.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodJunction.Properties.Resources.opser;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "OpScreen";
            this.Text = "Food Junction  : Restaurent Billing Systems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OpScreen_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Admin;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtManagerRes;
        private System.Windows.Forms.ToolStripMenuItem userManagemntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuTableMaster;
        private System.Windows.Forms.ToolStripMenuItem menuWaiterMaster;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCategoryMaster;
        private System.Windows.Forms.ToolStripMenuItem menuItemMas;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCustomerMaster;
        private System.Windows.Forms.ToolStripMenuItem menuTaxMaster;
        private System.Windows.Forms.ToolStripMenuItem menuBill;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billRegistrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billWiseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblstatusUserName;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer timer1;
    }
}



