namespace FoodJunction
{
    partial class F_Party
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGSTNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPContact = new System.Windows.Forms.TextBox();
            this.txtPAddress = new System.Windows.Forms.TextBox();
            this.txtPMobile = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPartyList = new System.Windows.Forms.DataGridView();
            this.PartyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartyList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAppend);
            this.panel2.Location = new System.Drawing.Point(12, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 57);
            this.panel2.TabIndex = 18;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtGSTNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPContact);
            this.panel1.Controls.Add(this.txtPAddress);
            this.panel1.Controls.Add(this.txtPMobile);
            this.panel1.Controls.Add(this.txtPName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 225);
            this.panel1.TabIndex = 17;
            // 
            // txtGSTNo
            // 
            this.txtGSTNo.Enabled = false;
            this.txtGSTNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSTNo.Location = new System.Drawing.Point(129, 191);
            this.txtGSTNo.Name = "txtGSTNo";
            this.txtGSTNo.Size = new System.Drawing.Size(175, 23);
            this.txtGSTNo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "GST No. :";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Enabled = false;
            this.txtPEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPEmail.Location = new System.Drawing.Point(129, 162);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(245, 23);
            this.txtPEmail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "eMail :";
            // 
            // txtPContact
            // 
            this.txtPContact.Enabled = false;
            this.txtPContact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPContact.Location = new System.Drawing.Point(129, 106);
            this.txtPContact.Name = "txtPContact";
            this.txtPContact.Size = new System.Drawing.Size(245, 23);
            this.txtPContact.TabIndex = 8;
            // 
            // txtPAddress
            // 
            this.txtPAddress.Enabled = false;
            this.txtPAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAddress.Location = new System.Drawing.Point(129, 47);
            this.txtPAddress.Multiline = true;
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.Size = new System.Drawing.Size(245, 55);
            this.txtPAddress.TabIndex = 7;
            // 
            // txtPMobile
            // 
            this.txtPMobile.Enabled = false;
            this.txtPMobile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPMobile.Location = new System.Drawing.Point(129, 134);
            this.txtPMobile.Name = "txtPMobile";
            this.txtPMobile.Size = new System.Drawing.Size(175, 23);
            this.txtPMobile.TabIndex = 6;
            // 
            // txtPName
            // 
            this.txtPName.Enabled = false;
            this.txtPName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(129, 19);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(245, 23);
            this.txtPName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Person :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // dgvPartyList
            // 
            this.dgvPartyList.AllowUserToAddRows = false;
            this.dgvPartyList.AllowUserToDeleteRows = false;
            this.dgvPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartyId,
            this.PName,
            this.PAddress,
            this.PMobile,
            this.PEmail,
            this.PContact,
            this.GSTNo});
            this.dgvPartyList.Location = new System.Drawing.Point(438, 45);
            this.dgvPartyList.Name = "dgvPartyList";
            this.dgvPartyList.ReadOnly = true;
            this.dgvPartyList.Size = new System.Drawing.Size(523, 297);
            this.dgvPartyList.TabIndex = 19;
            this.dgvPartyList.DoubleClick += new System.EventHandler(this.dgvPartyList_DoubleClick);
            // 
            // PartyId
            // 
            this.PartyId.DataPropertyName = "PartyId";
            this.PartyId.HeaderText = "ID";
            this.PartyId.Name = "PartyId";
            this.PartyId.ReadOnly = true;
            this.PartyId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartyId.Visible = false;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 200;
            // 
            // PAddress
            // 
            this.PAddress.DataPropertyName = "PAddress";
            this.PAddress.HeaderText = "PAddress";
            this.PAddress.Name = "PAddress";
            this.PAddress.ReadOnly = true;
            this.PAddress.Visible = false;
            // 
            // PMobile
            // 
            this.PMobile.DataPropertyName = "PMobile";
            this.PMobile.HeaderText = "Contact No";
            this.PMobile.Name = "PMobile";
            this.PMobile.ReadOnly = true;
            // 
            // PEmail
            // 
            this.PEmail.DataPropertyName = "PEmail";
            this.PEmail.HeaderText = "PEmail";
            this.PEmail.Name = "PEmail";
            this.PEmail.ReadOnly = true;
            this.PEmail.Width = 175;
            // 
            // PContact
            // 
            this.PContact.DataPropertyName = "PContact";
            this.PContact.HeaderText = "Contact Person";
            this.PContact.Name = "PContact";
            this.PContact.ReadOnly = true;
            this.PContact.Visible = false;
            this.PContact.Width = 50;
            // 
            // GSTNo
            // 
            this.GSTNo.DataPropertyName = "GSTNo";
            this.GSTNo.HeaderText = "GSTNo";
            this.GSTNo.Name = "GSTNo";
            this.GSTNo.ReadOnly = true;
            this.GSTNo.Visible = false;
            // 
            // F_Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(988, 375);
            this.Controls.Add(this.dgvPartyList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "F_Party";
            this.Text = "F_Party";
            this.Load += new System.EventHandler(this.F_Party_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPContact;
        private System.Windows.Forms.TextBox txtPAddress;
        private System.Windows.Forms.TextBox txtPMobile;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGSTNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPartyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTNo;
    }
}