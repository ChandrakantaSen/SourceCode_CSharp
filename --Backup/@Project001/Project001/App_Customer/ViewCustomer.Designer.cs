namespace Project001.App_Customer
{
    partial class ViewCustomer
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
			this.searchBox = new System.Windows.Forms.TextBox();
			this.seachBtn = new System.Windows.Forms.Button();
			this.clrBtn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search by Name:";
			// 
			// searchBox
			// 
			this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchBox.Location = new System.Drawing.Point(180, 26);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(242, 26);
			this.searchBox.TabIndex = 1;
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
			// 
			// seachBtn
			// 
			this.seachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seachBtn.ForeColor = System.Drawing.Color.Red;
			this.seachBtn.Location = new System.Drawing.Point(550, 22);
			this.seachBtn.Name = "seachBtn";
			this.seachBtn.Size = new System.Drawing.Size(95, 36);
			this.seachBtn.TabIndex = 2;
			this.seachBtn.Text = "&Close";
			this.seachBtn.UseVisualStyleBackColor = true;
			this.seachBtn.Click += new System.EventHandler(this.seachBtn_Click);
			// 
			// clrBtn
			// 
			this.clrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clrBtn.Location = new System.Drawing.Point(446, 22);
			this.clrBtn.Name = "clrBtn";
			this.clrBtn.Size = new System.Drawing.Size(98, 36);
			this.clrBtn.TabIndex = 4;
			this.clrBtn.Text = "&Clear";
			this.clrBtn.UseVisualStyleBackColor = true;
			this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 100);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1050, 384);
			this.dataGridView1.TabIndex = 5;
			// 
			// ViewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1076, 496);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.clrBtn);
			this.Controls.Add(this.seachBtn);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ViewCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ViewCustomer";
			this.Load += new System.EventHandler(this.ViewCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button seachBtn;
        private System.Windows.Forms.Button clrBtn;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}