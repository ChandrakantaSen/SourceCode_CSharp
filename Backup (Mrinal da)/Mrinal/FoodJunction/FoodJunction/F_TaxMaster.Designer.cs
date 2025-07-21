namespace FoodJunction
{
    partial class F_TaxMaster
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
            this.dgvTaxList = new System.Windows.Forms.DataGridView();
            this.TaxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHSNCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTaxList
            // 
            this.dgvTaxList.AllowUserToAddRows = false;
            this.dgvTaxList.AllowUserToDeleteRows = false;
            this.dgvTaxList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaxId,
            this.HSNCode,
            this.TRate,
            this.TaxDesc});
            this.dgvTaxList.Location = new System.Drawing.Point(29, 225);
            this.dgvTaxList.Name = "dgvTaxList";
            this.dgvTaxList.ReadOnly = true;
            this.dgvTaxList.Size = new System.Drawing.Size(319, 195);
            this.dgvTaxList.TabIndex = 10;
            this.dgvTaxList.DoubleClick += new System.EventHandler(this.dgvTaxList_DoubleClick);
            // 
            // TaxId
            // 
            this.TaxId.DataPropertyName = "TaxId";
            this.TaxId.HeaderText = "GrpId";
            this.TaxId.Name = "TaxId";
            this.TaxId.ReadOnly = true;
            this.TaxId.Visible = false;
            // 
            // HSNCode
            // 
            this.HSNCode.DataPropertyName = "HSNCode";
            this.HSNCode.HeaderText = "HSN Code";
            this.HSNCode.Name = "HSNCode";
            this.HSNCode.ReadOnly = true;
            this.HSNCode.Visible = false;
            this.HSNCode.Width = 200;
            // 
            // TRate
            // 
            this.TRate.DataPropertyName = "TRate";
            this.TRate.HeaderText = "Rate (%)";
            this.TRate.Name = "TRate";
            this.TRate.ReadOnly = true;
            this.TRate.Visible = false;
            this.TRate.Width = 75;
            // 
            // TaxDesc
            // 
            this.TaxDesc.DataPropertyName = "TaxDesc";
            this.TaxDesc.HeaderText = "Tax Description";
            this.TaxDesc.Name = "TaxDesc";
            this.TaxDesc.ReadOnly = true;
            this.TaxDesc.Width = 250;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAppend);
            this.panel2.Location = new System.Drawing.Point(29, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 55);
            this.panel2.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(222, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Delete";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(121, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Exit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppend.Location = new System.Drawing.Point(20, 12);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 32);
            this.btnAppend.TabIndex = 0;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTRate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHSNCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 95);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "(%)";
            // 
            // txtTRate
            // 
            this.txtTRate.Enabled = false;
            this.txtTRate.Location = new System.Drawing.Point(126, 52);
            this.txtTRate.Name = "txtTRate";
            this.txtTRate.Size = new System.Drawing.Size(48, 20);
            this.txtTRate.TabIndex = 3;
            this.txtTRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTRate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate :";
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Enabled = false;
            this.txtHSNCode.Location = new System.Drawing.Point(126, 15);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Size = new System.Drawing.Size(110, 20);
            this.txtHSNCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HSN Code :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tax Master";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_TaxMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(377, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTaxList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_TaxMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Master Form";
            this.Load += new System.EventHandler(this.F_TaxMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaxList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHSNCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxDesc;
        private System.Windows.Forms.Label label4;
    }
}