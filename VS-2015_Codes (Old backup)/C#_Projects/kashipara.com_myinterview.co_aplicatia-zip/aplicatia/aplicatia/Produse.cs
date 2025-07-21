using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Aplicatie
{
	/// <summary>
	/// Summary description for Produse.
	/// </summary>
	public class Produse : System.Windows.Forms.Form
	{
		private bool este=true;
		private OleDbConnection connection;
		private OleDbCommand cmd;
		private OleDbDataAdapter da;
		private DataSet ds;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader Id;
		private System.Windows.Forms.ColumnHeader Denumire;
		private System.Windows.Forms.ColumnHeader Cantitate;
		private System.Windows.Forms.ColumnHeader Um;
		private System.Windows.Forms.ColumnHeader Categorie;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Produse()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Um = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produse";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(32, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Id";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterii:";
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(32, 184);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Denumire";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(32, 232);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 24);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Categorie";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(32, 288);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(112, 24);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Cantitate minima";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Centrala termica",
            "Calorifer",
            "Tub pp cu mufa",
            "Cot",
            "Ramificatie",
            "Reductie ",
            "Piese curatire",
            "Mansou",
            "Conector ",
            "Ventil",
            "Tevi Al",
            "Tevi Cu"});
            this.comboBox1.Location = new System.Drawing.Point(144, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 288);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Denumire,
            this.Cantitate,
            this.Um,
            this.Categorie});
            this.listView1.Location = new System.Drawing.Point(312, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 296);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 61;
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 124;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.Width = 77;
            // 
            // Um
            // 
            this.Um.Text = "Um";
            this.Um.Width = 68;
            // 
            // Categorie
            // 
            this.Categorie.Text = "Categorie";
            this.Categorie.Width = 96;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cauta";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Refresh";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Produse
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = global::Aplicatie.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(768, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Produse";
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.Produse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (connection==null || connection.State == ConnectionState.Closed)
			{
				connection = new OleDbConnection();
				string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\firma.mdb;User Id=admin;Password=;";			
				connection.ConnectionString = connstr;
				connection.Open();
			}
			
			if (connection!=null && connection.State == ConnectionState.Open)
			{
				ds = new DataSet();
				cmd = new OleDbCommand();
				cmd.Connection = connection;
				// este 1 
				if (checkBox1.Checked==true)
				{
					//este 2
					if (checkBox2.Checked==true)
					{
						//este 3
						if (checkBox3.Checked==true)
						{
							//este 1-2-3-4
							if (checkBox4.Checked==true)
							{
								if((textBox2.Text=="")||(textBox1.Text=="")||(comboBox1.Text==""))
								{
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								    este=true;
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+"' and denumire ='"+textBox1.Text+"' and grupa ='"+comboBox1.Text+"' and cant>"+numericUpDown1.Value.ToString();
							        
								}
							}
								//nu este 4 --> 1-2-3
							else 
							{
								if((textBox2.Text=="")||(textBox1.Text=="")||(comboBox1.Text==""))
								{
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								    este=true;
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+" and denumire ='"+textBox1.Text+"' and grupa ='"+comboBox1.Text+"'";
							
								}
							}
						}
							//nu este 3
						else 
						{
							//este 1-2-4
							if (checkBox4.Checked==true)
							{
								if((textBox2.Text=="")||(textBox1.Text==""))
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+" and denumire ='"+textBox1.Text+"' and cant>"+numericUpDown1.Value.ToString();
							
								}
							}
								//nu este 4 --> 1-2
							else 
							{
								if((textBox2.Text=="")||(textBox1.Text==""))
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+" and denumire ='"+textBox1.Text+"'";
							
								}
							}
						}
					}
						//nu este 2
					else
					{
						//este 3
						if (checkBox3.Checked==true)
						{
							//este 1-3-4
							if (checkBox4.Checked==true)
							{
								if((textBox2.Text=="")||(comboBox1.Text==""))
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+" and grupa ='"+comboBox1.Text+"' and cant>"+numericUpDown1.Value.ToString();
								}
							}
								//nu este 4--> 1-3
							else 
							{
								if((textBox2.Text=="")||(comboBox1.Text==""))
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+" and grupa ='"+comboBox1.Text+"'";
								}
							}
						}
							//nu este 3
						else 
						{
							//este 1-4
							if (checkBox4.Checked==true)
							{
								if(textBox2.Text=="")
								{ 
									este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString()+" and cant>"+numericUpDown1.Value.ToString();
							
								}
							}
								//nu este 4 --> este 1
							else 
							{
								if(textBox2.Text=="")
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where id_material="+textBox2.Text.ToString();
								}
							}
						}
					}
				}
					//nu este 1 
				else 
				{
					//este 2
					if (checkBox2.Checked==true)
					{
						//este 3
						if (checkBox3.Checked==true)
						{
							//este 2-3-4
							if (checkBox4.Checked==true)
							{
								if((textBox1.Text=="")||(comboBox1.Text==""))
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where denumire ='"+textBox1.Text+"' and grupa ='"+comboBox1.Text+"' and cant>"+numericUpDown1.Value.ToString();
								}
							}
								//nu este 4 --> 2-3
							else 
							{
								if((textBox1.Text=="")||(comboBox1.Text==""))
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where denumire ='"+textBox1.Text+"' and grupa ='"+comboBox1.Text+"'";
								}
							}
						}
							//nu este 3
						else 
						{
							// este 2-4
							if (checkBox4.Checked==true)
							{
								if (textBox1.Text=="")
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where denumire ='"+textBox1.Text+"' and cant>"+numericUpDown1.Value.ToString();
								}
							}
								//nu este 4 --> 2
							else 
							{
								if(textBox1.Text=="")
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where denumire ='"+textBox1.Text+"'";
								}
							}
						}
					}
						//nu este 2
					else
					{
						//este 3
						if (checkBox3.Checked==true)
						{
							//este 3-4
							if (checkBox4.Checked==true)
							{
								if(comboBox1.Text=="")
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where grupa ='"+comboBox1.Text+"' and cant>"+numericUpDown1.Value.ToString();
								}
							}
								//nu este 4 --> 3
							else 
							{
								if (comboBox1.Text=="")
								{
									 este=true;
									MessageBox.Show("Toate campurile trebuie completate cu valori");
								}
								else
								{
									cmd.CommandText = "select * from produse where grupa ='"+comboBox1.Text+"'";
								}
							}
						}
							//nu este 3
						else 
						{
							//este 4
							if (checkBox4.Checked==true)
							{
								cmd.CommandText = "select * from produse where cant>"+numericUpDown1.Value.ToString();
							}
								//nu este 4--> nimic
							else 
							{
								MessageBox.Show("Trebuie sa selectati un criteriu");
							}
						}
					}
				}
				if (!este)
				{
					da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
					da.Fill(ds);
					bool este2=false;
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						ListViewItem  itm = new ListViewItem(row["id_produse"].ToString());
						itm.SubItems.Add(row["denumire"].ToString());
						itm.SubItems.Add(row["cant"].ToString());
						itm.SubItems.Add(row["um"].ToString());
						itm.SubItems.Add(row["grupa"].ToString());
						listView1.Items.Add(itm);
						este2=true;
					}
					if (!este2)
					{
						MessageBox.Show("Produsul nu a fost gasit");
					}
				}
				else 
				{
					este=false;
				}
			}
			if (connection!=null && (connection.State == ConnectionState.Open || connection.State == ConnectionState.Connecting))
			{
				connection.Close();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			textBox1.Text="";
			textBox2.Text="";
			comboBox1.Text="";
			este=false;
			
			listView1.Items.Clear();
			checkBox1.Checked=false;
			checkBox2.Checked=false;
			checkBox3.Checked=false;
			checkBox4.Checked=false;
			
			textBox1.Visible=false;
			textBox2.Visible=false;
			comboBox1.Visible=false;
			comboBox1.Text="";
			numericUpDown1.Visible=false;
			numericUpDown1.Value=0;

		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox1.Checked==true)
			{
				textBox2.Visible=true;
			}
			else
			{
				textBox2.Visible=false;
			}

		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox2.Checked==true)
			{
				textBox1.Visible=true;
			}
			else
			{
				textBox1.Visible=false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox3.Checked==true)
			{
				comboBox1.Visible=true;
			}
			else
			{
				comboBox1.Visible=false;
			}
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox4.Checked==true)
			{
				numericUpDown1.Visible=true;
			}
			else
			{
				numericUpDown1.Visible=false;
			}
		}

		private void Produse_Load(object sender, System.EventArgs e)
		{
		
		}


	}
}
