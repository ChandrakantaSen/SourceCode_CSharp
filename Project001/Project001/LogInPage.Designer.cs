/*
 * Created by SharpDevelop.
 * User: user
 * Date: 10/9/2017
 * Time: 11:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Project001
{
	partial class LogInPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
			this.lbl_LoginHead = new System.Windows.Forms.Label();
			this.pnl_LoginHead = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Lbl_Copyright = new System.Windows.Forms.Label();
			this.GrpBx_SignIn = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.Btn_Clear = new System.Windows.Forms.Button();
			this.Btn_Submit = new System.Windows.Forms.Button();
			this.Txt_Password = new System.Windows.Forms.TextBox();
			this.Txt_UserName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Drp_UserType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PicBox = new System.Windows.Forms.PictureBox();
			this.pnl_LoginHead.SuspendLayout();
			this.panel1.SuspendLayout();
			this.GrpBx_SignIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_LoginHead
			// 
			this.lbl_LoginHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbl_LoginHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_LoginHead.Location = new System.Drawing.Point(13, 9);
			this.lbl_LoginHead.Name = "lbl_LoginHead";
			this.lbl_LoginHead.Size = new System.Drawing.Size(279, 29);
			this.lbl_LoginHead.TabIndex = 0;
			this.lbl_LoginHead.Text = "Inventory Management System";
			this.lbl_LoginHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_LoginHead
			// 
			this.pnl_LoginHead.BackColor = System.Drawing.Color.Silver;
			this.pnl_LoginHead.Controls.Add(this.lbl_LoginHead);
			this.pnl_LoginHead.Location = new System.Drawing.Point(-1, 0);
			this.pnl_LoginHead.Name = "pnl_LoginHead";
			this.pnl_LoginHead.Size = new System.Drawing.Size(683, 46);
			this.pnl_LoginHead.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.Lbl_Copyright);
			this.panel1.Location = new System.Drawing.Point(-1, 446);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(683, 23);
			this.panel1.TabIndex = 2;
			// 
			// Lbl_Copyright
			// 
			this.Lbl_Copyright.AutoSize = true;
			this.Lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Copyright.Location = new System.Drawing.Point(3, 2);
			this.Lbl_Copyright.Name = "Lbl_Copyright";
			this.Lbl_Copyright.Size = new System.Drawing.Size(181, 15);
			this.Lbl_Copyright.TabIndex = 0;
			this.Lbl_Copyright.Text = "Copyright and all rights reserved";
			this.Lbl_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GrpBx_SignIn
			// 
			this.GrpBx_SignIn.Controls.Add(this.checkBox1);
			this.GrpBx_SignIn.Controls.Add(this.Btn_Clear);
			this.GrpBx_SignIn.Controls.Add(this.Btn_Submit);
			this.GrpBx_SignIn.Controls.Add(this.Txt_Password);
			this.GrpBx_SignIn.Controls.Add(this.Txt_UserName);
			this.GrpBx_SignIn.Controls.Add(this.label3);
			this.GrpBx_SignIn.Controls.Add(this.label2);
			this.GrpBx_SignIn.Controls.Add(this.Drp_UserType);
			this.GrpBx_SignIn.Controls.Add(this.label1);
			this.GrpBx_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GrpBx_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrpBx_SignIn.Location = new System.Drawing.Point(288, 92);
			this.GrpBx_SignIn.Name = "GrpBx_SignIn";
			this.GrpBx_SignIn.Size = new System.Drawing.Size(382, 249);
			this.GrpBx_SignIn.TabIndex = 3;
			this.GrpBx_SignIn.TabStop = false;
			this.GrpBx_SignIn.Text = "Sign In";
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(118, 170);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(132, 30);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Remember Me";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Btn_Clear
			// 
			this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Clear.Location = new System.Drawing.Point(296, 206);
			this.Btn_Clear.Name = "Btn_Clear";
			this.Btn_Clear.Size = new System.Drawing.Size(78, 29);
			this.Btn_Clear.TabIndex = 8;
			this.Btn_Clear.Text = "&Clear";
			this.Btn_Clear.UseVisualStyleBackColor = true;
			this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
			// 
			// Btn_Submit
			// 
			this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Submit.Location = new System.Drawing.Point(212, 206);
			this.Btn_Submit.Name = "Btn_Submit";
			this.Btn_Submit.Size = new System.Drawing.Size(78, 29);
			this.Btn_Submit.TabIndex = 6;
			this.Btn_Submit.Text = "&Sign In";
			this.Btn_Submit.UseVisualStyleBackColor = true;
			this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
			// 
			// Txt_Password
			// 
			this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Txt_Password.Location = new System.Drawing.Point(118, 142);
			this.Txt_Password.Name = "Txt_Password";
			this.Txt_Password.PasswordChar = '*';
			this.Txt_Password.Size = new System.Drawing.Size(256, 22);
			this.Txt_Password.TabIndex = 5;
			// 
			// Txt_UserName
			// 
			this.Txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Txt_UserName.Location = new System.Drawing.Point(118, 108);
			this.Txt_UserName.Name = "Txt_UserName";
			this.Txt_UserName.Size = new System.Drawing.Size(256, 22);
			this.Txt_UserName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "User Type:  ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password:  ";
			// 
			// Drp_UserType
			// 
			this.Drp_UserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Drp_UserType.FormattingEnabled = true;
			this.Drp_UserType.Items.AddRange(new object[] {
									"Administrator",
									"Manager",
									"Accountant",
									"User"});
			this.Drp_UserType.Location = new System.Drawing.Point(118, 57);
			this.Drp_UserType.Name = "Drp_UserType";
			this.Drp_UserType.Size = new System.Drawing.Size(256, 24);
			this.Drp_UserType.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Type:  ";
			// 
			// PicBox
			// 
			this.PicBox.Image = ((System.Drawing.Image)(resources.GetObject("PicBox.Image")));
			this.PicBox.Location = new System.Drawing.Point(8, 52);
			this.PicBox.Name = "PicBox";
			this.PicBox.Size = new System.Drawing.Size(274, 388);
			this.PicBox.TabIndex = 4;
			this.PicBox.TabStop = false;
			// 
			// LogInPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 467);
			this.Controls.Add(this.PicBox);
			this.Controls.Add(this.GrpBx_SignIn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_LoginHead);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogInPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.Load += new System.EventHandler(this.LogInPage_Load);
			this.pnl_LoginHead.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.GrpBx_SignIn.ResumeLayout(false);
			this.GrpBx_SignIn.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label Lbl_Copyright;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.PictureBox PicBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_UserName;
		private System.Windows.Forms.TextBox Txt_Password;
		private System.Windows.Forms.Button Btn_Submit;
		private System.Windows.Forms.Button Btn_Clear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Drp_UserType;
		private System.Windows.Forms.GroupBox GrpBx_SignIn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnl_LoginHead;
		private System.Windows.Forms.Label lbl_LoginHead;
	}
}
