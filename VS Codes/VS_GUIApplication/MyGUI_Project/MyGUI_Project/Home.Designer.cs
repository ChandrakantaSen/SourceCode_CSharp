namespace MyGUI_Project
{
    partial class Home
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
            System.Windows.Forms.Splitter splitter1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftHead = new System.Windows.Forms.Label();
            this.RightHead = new System.Windows.Forms.Label();
            this.Purchase = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.Departments = new System.Windows.Forms.Button();
            this.Tenant = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.Quotation = new System.Windows.Forms.Button();
            this.Office = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            splitter1 = new System.Windows.Forms.Splitter();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(255, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(444, 10);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.LeftHead);
            this.TopPanel.Controls.Add(splitter1);
            this.TopPanel.Controls.Add(this.RightHead);
            this.TopPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TopPanel.Location = new System.Drawing.Point(1, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(984, 25);
            this.TopPanel.TabIndex = 1;
            // 
            // LeftHead
            // 
            this.LeftHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftHead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftHead.Location = new System.Drawing.Point(3, 0);
            this.LeftHead.Name = "LeftHead";
            this.LeftHead.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LeftHead.Size = new System.Drawing.Size(246, 16);
            this.LeftHead.TabIndex = 2;
            this.LeftHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RightHead
            // 
            this.RightHead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightHead.Location = new System.Drawing.Point(705, 0);
            this.RightHead.Name = "RightHead";
            this.RightHead.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.RightHead.Size = new System.Drawing.Size(267, 16);
            this.RightHead.TabIndex = 0;
            this.RightHead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Purchase.Location = new System.Drawing.Point(746, 72);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(212, 144);
            this.Purchase.TabIndex = 2;
            this.Purchase.Text = "Purchase Management";
            this.Purchase.UseVisualStyleBackColor = false;
            // 
            // Sales
            // 
            this.Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(505, 72);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(212, 144);
            this.Sales.TabIndex = 3;
            this.Sales.Text = "Sales Management";
            this.Sales.UseVisualStyleBackColor = false;
            // 
            // Departments
            // 
            this.Departments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Departments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Departments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departments.Location = new System.Drawing.Point(268, 72);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(212, 144);
            this.Departments.TabIndex = 4;
            this.Departments.Text = "Departments";
            this.Departments.UseVisualStyleBackColor = false;
            // 
            // Tenant
            // 
            this.Tenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tenant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenant.Location = new System.Drawing.Point(32, 72);
            this.Tenant.Name = "Tenant";
            this.Tenant.Size = new System.Drawing.Size(212, 144);
            this.Tenant.TabIndex = 5;
            this.Tenant.Text = "Tenant \r\n(Organisation Creation)";
            this.Tenant.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(746, 248);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(212, 144);
            this.Stock.TabIndex = 6;
            this.Stock.Text = "Stock Management";
            this.Stock.UseVisualStyleBackColor = false;
            // 
            // Quotation
            // 
            this.Quotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Quotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quotation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quotation.Location = new System.Drawing.Point(268, 248);
            this.Quotation.Name = "Quotation";
            this.Quotation.Size = new System.Drawing.Size(212, 144);
            this.Quotation.TabIndex = 7;
            this.Quotation.Text = "Quotation";
            this.Quotation.UseVisualStyleBackColor = false;
            // 
            // Office
            // 
            this.Office.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Office.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Office.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office.Location = new System.Drawing.Point(505, 248);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(212, 144);
            this.Office.TabIndex = 8;
            this.Office.Text = "Office Management";
            this.Office.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Location = new System.Drawing.Point(32, 248);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(212, 144);
            this.Reports.TabIndex = 9;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(32, 420);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(212, 144);
            this.Settings.TabIndex = 10;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(883, 541);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 11;
            this.LogOut.Text = "button1";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 590);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.Office);
            this.Controls.Add(this.Quotation);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Tenant);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Home_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TopPanel;
        private System.Windows.Forms.Label RightHead;
        private System.Windows.Forms.Label LeftHead;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button Departments;
        private System.Windows.Forms.Button Tenant;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button Quotation;
        private System.Windows.Forms.Button Office;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button LogOut;


    }
}

