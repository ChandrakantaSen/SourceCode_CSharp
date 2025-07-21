namespace GUI_Application
{
    partial class Form17
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
            this.l1 = new System.Windows.Forms.ListBox();
            this.l2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.Items.AddRange(new object[] {
            "Kolkata",
            "Delhi",
            "Rajasthan",
            "Mumbai",
            "Chennai",
            "Bengaluru",
            "Kochi",
            "Kashmir",
            "Imphal"});
            this.l1.Location = new System.Drawing.Point(12, 12);
            this.l1.Name = "l1";
            this.l1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.l1.Size = new System.Drawing.Size(174, 173);
            this.l1.TabIndex = 0;
            // 
            // l2
            // 
            this.l2.FormattingEnabled = true;
            this.l2.Location = new System.Drawing.Point(274, 12);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(174, 173);
            this.l2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = ">>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 193);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form17";
            this.Text = "Form17";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.ListBox l2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}