namespace GUI_Application
{
    partial class Form21
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEq = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bMUL = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.bP = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.Color.Tomato;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.ForeColor = System.Drawing.Color.Black;
            this.t1.Location = new System.Drawing.Point(19, 17);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(425, 26);
            this.t1.TabIndex = 0;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b6);
            this.groupBox1.Controls.Add(this.b8);
            this.groupBox1.Controls.Add(this.b9);
            this.groupBox1.Controls.Add(this.b0);
            this.groupBox1.Controls.Add(this.b7);
            this.groupBox1.Controls.Add(this.b4);
            this.groupBox1.Controls.Add(this.b3);
            this.groupBox1.Controls.Add(this.b5);
            this.groupBox1.Controls.Add(this.b2);
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Location = new System.Drawing.Point(20, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(80, 25);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(56, 34);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(15, 24);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(59, 35);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bEq);
            this.groupBox2.Controls.Add(this.bD);
            this.groupBox2.Controls.Add(this.bMUL);
            this.groupBox2.Controls.Add(this.bM);
            this.groupBox2.Controls.Add(this.bP);
            this.groupBox2.Location = new System.Drawing.Point(318, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button Controls";
            // 
            // bEq
            // 
            this.bEq.Location = new System.Drawing.Point(38, 99);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(56, 33);
            this.bEq.TabIndex = 6;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(64, 60);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(56, 33);
            this.bD.TabIndex = 5;
            this.bD.Text = "/";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bMUL
            // 
            this.bMUL.Location = new System.Drawing.Point(6, 59);
            this.bMUL.Name = "bMUL";
            this.bMUL.Size = new System.Drawing.Size(52, 34);
            this.bMUL.TabIndex = 4;
            this.bMUL.Text = "*";
            this.bMUL.UseVisualStyleBackColor = true;
            this.bMUL.Click += new System.EventHandler(this.bMUL_Click);
            // 
            // bM
            // 
            this.bM.Location = new System.Drawing.Point(64, 19);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(56, 34);
            this.bM.TabIndex = 3;
            this.bM.Text = "-";
            this.bM.UseVisualStyleBackColor = true;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // bP
            // 
            this.bP.Location = new System.Drawing.Point(6, 19);
            this.bP.Name = "bP";
            this.bP.Size = new System.Drawing.Size(52, 34);
            this.bP.TabIndex = 2;
            this.bP.Text = "+";
            this.bP.UseVisualStyleBackColor = true;
            this.bP.Click += new System.EventHandler(this.bP_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(15, 76);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(59, 35);
            this.b5.TabIndex = 2;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(142, 24);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(65, 35);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(213, 24);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(63, 35);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(142, 76);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(65, 35);
            this.b7.TabIndex = 5;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(142, 127);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(65, 36);
            this.b0.TabIndex = 6;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(80, 127);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(56, 36);
            this.b9.TabIndex = 7;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(213, 76);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(63, 35);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(80, 76);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(56, 35);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.t1);
            this.Name = "Form21";
            this.Text = "Form21";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bMUL;
        private System.Windows.Forms.Button bM;
        private System.Windows.Forms.Button bP;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b5;
    }
}