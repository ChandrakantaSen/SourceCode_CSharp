/*
 * Created by SharpDevelop.
 * User: user
 * Date: 10/13/2017
 * Time: 8:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project001
{
	partial class HomePage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lockUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vendorManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editUpdateMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lockMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tenantViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HomeFooterStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.HomeFooterStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.vendorManagementToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(678, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "TopMenuBar";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.openToolStripMenuItem.Text = "&Open";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveAsToolStripMenuItem.Text = "&Save As";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.printToolStripMenuItem.Text = "&Print";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.cutToolStripMenuItem.Text = "&Cut";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			// 
			// userManagementToolStripMenuItem
			// 
			this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.viewUserToolStripMenuItem,
            this.aaToolStripMenuItem,
            this.lockUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
			this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
			this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
			this.userManagementToolStripMenuItem.Text = "&Customer Management";
			// 
			// addUserToolStripMenuItem
			// 
			this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
			this.addUserToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.addUserToolStripMenuItem.Text = "&Add Customer";
			this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
			// 
			// viewUserToolStripMenuItem
			// 
			this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
			this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.viewUserToolStripMenuItem.Text = "&View Customer";
			this.viewUserToolStripMenuItem.Click += new System.EventHandler(this.viewUserToolStripMenuItem_Click);
			// 
			// aaToolStripMenuItem
			// 
			this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
			this.aaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.aaToolStripMenuItem.Text = "&Edit/Update Customer";
			this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click);
			// 
			// lockUserToolStripMenuItem
			// 
			this.lockUserToolStripMenuItem.Name = "lockUserToolStripMenuItem";
			this.lockUserToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.lockUserToolStripMenuItem.Text = "&Lock User";
			// 
			// deleteUserToolStripMenuItem
			// 
			this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
			this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.deleteUserToolStripMenuItem.Text = "&Delete User";
			// 
			// vendorManagementToolStripMenuItem
			// 
			this.vendorManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.salesToolStripMenuItem,
            this.editUpdateMedicineToolStripMenuItem,
            this.lockMedicineToolStripMenuItem,
            this.deleteMedicineToolStripMenuItem});
			this.vendorManagementToolStripMenuItem.Name = "vendorManagementToolStripMenuItem";
			this.vendorManagementToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
			this.vendorManagementToolStripMenuItem.Text = "&Product Management";
			this.vendorManagementToolStripMenuItem.Click += new System.EventHandler(this.vendorManagementToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
			this.toolStripMenuItem2.Text = "&Add Medicine";
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.salesToolStripMenuItem.Text = "&View Medicine";
			this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
			// 
			// editUpdateMedicineToolStripMenuItem
			// 
			this.editUpdateMedicineToolStripMenuItem.Name = "editUpdateMedicineToolStripMenuItem";
			this.editUpdateMedicineToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.editUpdateMedicineToolStripMenuItem.Text = "&Edit/Update Medicine";
			// 
			// lockMedicineToolStripMenuItem
			// 
			this.lockMedicineToolStripMenuItem.Name = "lockMedicineToolStripMenuItem";
			this.lockMedicineToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.lockMedicineToolStripMenuItem.Text = "&Lock Medicine";
			// 
			// deleteMedicineToolStripMenuItem
			// 
			this.deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
			this.deleteMedicineToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.deleteMedicineToolStripMenuItem.Text = "&Delete Medicine";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenantToolStripMenuItem,
            this.tenantViewToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// tenantToolStripMenuItem
			// 
			this.tenantToolStripMenuItem.Name = "tenantToolStripMenuItem";
			this.tenantToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.tenantToolStripMenuItem.Text = "&Tenant Creation";
			this.tenantToolStripMenuItem.Click += new System.EventHandler(this.TenantToolStripMenuItem_Click);
			// 
			// tenantViewToolStripMenuItem
			// 
			this.tenantViewToolStripMenuItem.Name = "tenantViewToolStripMenuItem";
			this.tenantViewToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.tenantViewToolStripMenuItem.Text = "&Tenant View";
			// 
			// HomeFooterStrip
			// 
			this.HomeFooterStrip.BackColor = System.Drawing.Color.Gainsboro;
			this.HomeFooterStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.HomeFooterStrip.Location = new System.Drawing.Point(0, 445);
			this.HomeFooterStrip.Name = "HomeFooterStrip";
			this.HomeFooterStrip.Size = new System.Drawing.Size(678, 22);
			this.HomeFooterStrip.TabIndex = 4;
			this.HomeFooterStrip.Text = "HomeFooterStrip";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(166, 17);
			this.toolStripStatusLabel1.Text = "CopyRight@all rights reserved";
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(678, 467);
			this.Controls.Add(this.HomeFooterStrip);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HomePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HomePage";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.HomePage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.HomeFooterStrip.ResumeLayout(false);
			this.HomeFooterStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem tenantToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lockUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem vendorManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip HomeFooterStrip;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tenantViewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editUpdateMedicineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lockMedicineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteMedicineToolStripMenuItem;
	}
}
