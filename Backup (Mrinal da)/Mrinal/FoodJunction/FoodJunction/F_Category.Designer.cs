namespace FoodJunction
{
    partial class F_Category
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
            this.txtGCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.dgvGrpList = new System.Windows.Forms.DataGridView();
            this.GrpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrpList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Code :";
            // 
            // txtGCode
            // 
            this.txtGCode.Enabled = false;
            this.txtGCode.Location = new System.Drawing.Point(126, 15);
            this.txtGCode.Name = "txtGCode";
            this.txtGCode.Size = new System.Drawing.Size(44, 20);
            this.txtGCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category :";
            // 
            // txtGDesc
            // 
            this.txtGDesc.Enabled = false;
            this.txtGDesc.Location = new System.Drawing.Point(126, 52);
            this.txtGDesc.Name = "txtGDesc";
            this.txtGDesc.Size = new System.Drawing.Size(155, 20);
            this.txtGDesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoary Master";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtGDesc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 95);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAppend);
            this.panel2.Location = new System.Drawing.Point(29, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 55);
            this.panel2.TabIndex = 6;
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
            // dgvGrpList
            // 
            this.dgvGrpList.AllowUserToAddRows = false;
            this.dgvGrpList.AllowUserToDeleteRows = false;
            this.dgvGrpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrpId,
            this.GrpCode,
            this.GrpDesc});
            this.dgvGrpList.Location = new System.Drawing.Point(29, 222);
            this.dgvGrpList.Name = "dgvGrpList";
            this.dgvGrpList.ReadOnly = true;
            this.dgvGrpList.Size = new System.Drawing.Size(319, 195);
            this.dgvGrpList.TabIndex = 7;
            this.dgvGrpList.DoubleClick += new System.EventHandler(this.dgvGrpList_DoubleClick);
            // 
            // GrpId
            // 
            this.GrpId.DataPropertyName = "GrpId";
            this.GrpId.HeaderText = "GrpId";
            this.GrpId.Name = "GrpId";
            this.GrpId.ReadOnly = true;
            this.GrpId.Visible = false;
            // 
            // GrpCode
            // 
            this.GrpCode.DataPropertyName = "GrpCode";
            this.GrpCode.HeaderText = "Code";
            this.GrpCode.Name = "GrpCode";
            this.GrpCode.ReadOnly = true;
            this.GrpCode.Width = 75;
            // 
            // GrpDesc
            // 
            this.GrpDesc.DataPropertyName = "GrpDesc";
            this.GrpDesc.HeaderText = "Description";
            this.GrpDesc.Name = "GrpDesc";
            this.GrpDesc.ReadOnly = true;
            this.GrpDesc.Width = 180;
            // 
            // F_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 429);
            this.Controls.Add(this.dgvGrpList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "F_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Category Master Form";
            this.Load += new System.EventHandler(this.F_Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrpList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.DataGridView dgvGrpList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrpDesc;
    }
}