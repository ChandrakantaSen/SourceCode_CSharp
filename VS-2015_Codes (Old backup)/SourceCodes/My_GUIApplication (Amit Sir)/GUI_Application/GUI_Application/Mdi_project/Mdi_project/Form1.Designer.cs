namespace Mdi_project
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawlFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithdrawlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositFormToolStripMenuItem,
            this.withdrawlFormToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmExitToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // depositFormToolStripMenuItem
            // 
            this.depositFormToolStripMenuItem.Name = "depositFormToolStripMenuItem";
            this.depositFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.depositFormToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.depositFormToolStripMenuItem.Text = "Deposit Form";
            this.depositFormToolStripMenuItem.Click += new System.EventHandler(this.depositFormToolStripMenuItem_Click);
            // 
            // withdrawlFormToolStripMenuItem
            // 
            this.withdrawlFormToolStripMenuItem.Name = "withdrawlFormToolStripMenuItem";
            this.withdrawlFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.withdrawlFormToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.withdrawlFormToolStripMenuItem.Text = "Withdrawl Form";
            this.withdrawlFormToolStripMenuItem.Click += new System.EventHandler(this.withdrawlFormToolStripMenuItem_Click);
            // 
            // confirmExitToolStripMenuItem
            // 
            this.confirmExitToolStripMenuItem.Name = "confirmExitToolStripMenuItem";
            this.confirmExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.confirmExitToolStripMenuItem.Text = "Confirm Exit";
            this.confirmExitToolStripMenuItem.Click += new System.EventHandler(this.confirmExitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDepositToolStripMenuItem,
            this.openWithdrawlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // openDepositToolStripMenuItem
            // 
            this.openDepositToolStripMenuItem.Name = "openDepositToolStripMenuItem";
            this.openDepositToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openDepositToolStripMenuItem.Text = "Open Deposit";
            this.openDepositToolStripMenuItem.Click += new System.EventHandler(this.openDepositToolStripMenuItem_Click);
            // 
            // openWithdrawlToolStripMenuItem
            // 
            this.openWithdrawlToolStripMenuItem.Name = "openWithdrawlToolStripMenuItem";
            this.openWithdrawlToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openWithdrawlToolStripMenuItem.Text = "Open Withdrawl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 286);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Banking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawlFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmExitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithdrawlToolStripMenuItem;
    }
}

