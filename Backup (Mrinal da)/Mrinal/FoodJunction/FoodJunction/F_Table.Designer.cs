namespace FoodJunction
{
    partial class F_Table
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTabNo = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAct = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TabId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table No. : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details : ";
            // 
            // txtTabNo
            // 
            this.txtTabNo.Enabled = false;
            this.txtTabNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabNo.Location = new System.Drawing.Point(95, 18);
            this.txtTabNo.Name = "txtTabNo";
            this.txtTabNo.Size = new System.Drawing.Size(100, 23);
            this.txtTabNo.TabIndex = 2;
            // 
            // txtDetails
            // 
            this.txtDetails.Enabled = false;
            this.txtDetails.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(95, 54);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(192, 23);
            this.txtDetails.TabIndex = 3;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TabId,
            this.TabNo,
            this.TabNam,
            this.Activ});
            this.dgvList.Location = new System.Drawing.Point(343, 35);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(400, 229);
            this.dgvList.TabIndex = 4;
            this.dgvList.DoubleClick += new System.EventHandler(this.dgvList_DoubleClick);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.Location = new System.Drawing.Point(8, 10);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 32);
            this.btnAddSave.TabIndex = 5;
            this.btnAddSave.Text = "Append";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(110, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Exit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(212, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Delete";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAct);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.txtTabNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 129);
            this.panel1.TabIndex = 8;
            // 
            // chkAct
            // 
            this.chkAct.AutoSize = true;
            this.chkAct.Checked = true;
            this.chkAct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAct.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAct.Location = new System.Drawing.Point(95, 95);
            this.chkAct.Name = "chkAct";
            this.chkAct.Size = new System.Drawing.Size(58, 17);
            this.chkAct.TabIndex = 4;
            this.chkAct.Text = "Active";
            this.chkAct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAddSave);
            this.panel2.Location = new System.Drawing.Point(36, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 52);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(36, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table Master";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabId
            // 
            this.TabId.DataPropertyName = "TabId";
            this.TabId.HeaderText = "Column1";
            this.TabId.Name = "TabId";
            this.TabId.ReadOnly = true;
            this.TabId.Visible = false;
            // 
            // TabNo
            // 
            this.TabNo.DataPropertyName = "TabNo";
            this.TabNo.HeaderText = "Table No";
            this.TabNo.Name = "TabNo";
            this.TabNo.ReadOnly = true;
            this.TabNo.Width = 75;
            // 
            // TabNam
            // 
            this.TabNam.DataPropertyName = "TabNam";
            this.TabNam.HeaderText = "Description";
            this.TabNam.Name = "TabNam";
            this.TabNam.ReadOnly = true;
            this.TabNam.Width = 220;
            // 
            // Activ
            // 
            this.Activ.DataPropertyName = "Activ";
            this.Activ.HeaderText = "Active";
            this.Activ.Name = "Activ";
            this.Activ.ReadOnly = true;
            this.Activ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activ.Width = 50;
            // 
            // F_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvList);
            this.Name = "F_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Master Form";
            this.Load += new System.EventHandler(this.F_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTabNo;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabNam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activ;
    }
}