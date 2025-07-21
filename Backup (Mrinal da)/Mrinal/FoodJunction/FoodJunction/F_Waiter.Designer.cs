namespace FoodJunction
{
    partial class F_Waiter
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWaiterCode = new System.Windows.Forms.TextBox();
            this.txtWaiterName = new System.Windows.Forms.TextBox();
            this.txtWAddress = new System.Windows.Forms.TextBox();
            this.txtWContact = new System.Windows.Forms.TextBox();
            this.chkActiv = new System.Windows.Forms.CheckBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvWaiterList = new System.Windows.Forms.DataGridView();
            this.WaiterId = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WaiterCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaiterNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiterList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Waiter Master Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiter Code : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact : ";
            // 
            // txtWaiterCode
            // 
            this.txtWaiterCode.Enabled = false;
            this.txtWaiterCode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaiterCode.Location = new System.Drawing.Point(129, 19);
            this.txtWaiterCode.Name = "txtWaiterCode";
            this.txtWaiterCode.Size = new System.Drawing.Size(67, 23);
            this.txtWaiterCode.TabIndex = 5;
            // 
            // txtWaiterName
            // 
            this.txtWaiterName.Enabled = false;
            this.txtWaiterName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaiterName.Location = new System.Drawing.Point(129, 55);
            this.txtWaiterName.Name = "txtWaiterName";
            this.txtWaiterName.Size = new System.Drawing.Size(224, 23);
            this.txtWaiterName.TabIndex = 6;
            // 
            // txtWAddress
            // 
            this.txtWAddress.Enabled = false;
            this.txtWAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWAddress.Location = new System.Drawing.Point(129, 91);
            this.txtWAddress.Multiline = true;
            this.txtWAddress.Name = "txtWAddress";
            this.txtWAddress.Size = new System.Drawing.Size(224, 55);
            this.txtWAddress.TabIndex = 7;
            // 
            // txtWContact
            // 
            this.txtWContact.Enabled = false;
            this.txtWContact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWContact.Location = new System.Drawing.Point(129, 158);
            this.txtWContact.Name = "txtWContact";
            this.txtWContact.Size = new System.Drawing.Size(224, 23);
            this.txtWContact.TabIndex = 8;
            // 
            // chkActiv
            // 
            this.chkActiv.AutoSize = true;
            this.chkActiv.Enabled = false;
            this.chkActiv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiv.Location = new System.Drawing.Point(129, 191);
            this.chkActiv.Name = "chkActiv";
            this.chkActiv.Size = new System.Drawing.Size(67, 20);
            this.chkActiv.TabIndex = 9;
            this.chkActiv.Text = "Active ";
            this.chkActiv.UseVisualStyleBackColor = true;
            // 
            // btnAppend
            // 
            this.btnAppend.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppend.Location = new System.Drawing.Point(22, 11);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 32);
            this.btnAppend.TabIndex = 10;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(150, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Exit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvWaiterList
            // 
            this.dgvWaiterList.AllowUserToAddRows = false;
            this.dgvWaiterList.AllowUserToDeleteRows = false;
            this.dgvWaiterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaiterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WaiterId,
            this.WaiterCode,
            this.WaiterNam,
            this.WAddress,
            this.WContact,
            this.Activ});
            this.dgvWaiterList.Location = new System.Drawing.Point(453, 56);
            this.dgvWaiterList.Name = "dgvWaiterList";
            this.dgvWaiterList.ReadOnly = true;
            this.dgvWaiterList.Size = new System.Drawing.Size(523, 297);
            this.dgvWaiterList.TabIndex = 13;
            this.dgvWaiterList.DoubleClick += new System.EventHandler(this.dgvWaiterList_DoubleClick);
            // 
            // WaiterId
            // 
            this.WaiterId.DataPropertyName = "WaiterId";
            this.WaiterId.HeaderText = "ID";
            this.WaiterId.Name = "WaiterId";
            this.WaiterId.ReadOnly = true;
            this.WaiterId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WaiterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WaiterId.Visible = false;
            // 
            // WaiterCode
            // 
            this.WaiterCode.DataPropertyName = "WaiterCode";
            this.WaiterCode.HeaderText = "Code No";
            this.WaiterCode.Name = "WaiterCode";
            this.WaiterCode.ReadOnly = true;
            this.WaiterCode.Width = 75;
            // 
            // WaiterNam
            // 
            this.WaiterNam.DataPropertyName = "WaiterNam";
            this.WaiterNam.HeaderText = "Name";
            this.WaiterNam.Name = "WaiterNam";
            this.WaiterNam.ReadOnly = true;
            this.WaiterNam.Width = 200;
            // 
            // WAddress
            // 
            this.WAddress.DataPropertyName = "WAddress";
            this.WAddress.HeaderText = "Address";
            this.WAddress.Name = "WAddress";
            this.WAddress.ReadOnly = true;
            this.WAddress.Visible = false;
            // 
            // WContact
            // 
            this.WContact.DataPropertyName = "WContact";
            this.WContact.HeaderText = "Contact No";
            this.WContact.Name = "WContact";
            this.WContact.ReadOnly = true;
            this.WContact.Width = 150;
            // 
            // Activ
            // 
            this.Activ.DataPropertyName = "Activ";
            this.Activ.HeaderText = "Active";
            this.Activ.Name = "Activ";
            this.Activ.ReadOnly = true;
            this.Activ.Width = 50;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(278, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Delete";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkActiv);
            this.panel1.Controls.Add(this.txtWContact);
            this.panel1.Controls.Add(this.txtWAddress);
            this.panel1.Controls.Add(this.txtWaiterName);
            this.panel1.Controls.Add(this.txtWaiterCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 225);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAppend);
            this.panel2.Location = new System.Drawing.Point(40, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 57);
            this.panel2.TabIndex = 16;
            // 
            // F_Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(988, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvWaiterList);
            this.Controls.Add(this.label1);
            this.Name = "F_Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Waiter Master Form";
            this.Load += new System.EventHandler(this.F_Waiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiterList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWaiterCode;
        private System.Windows.Forms.TextBox txtWaiterName;
        private System.Windows.Forms.TextBox txtWAddress;
        private System.Windows.Forms.TextBox txtWContact;
        private System.Windows.Forms.CheckBox chkActiv;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvWaiterList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WaiterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn WContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activ;
    }
}