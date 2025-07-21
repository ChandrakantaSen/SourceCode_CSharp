using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GUI_Application
{
    public partial class Form22 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com;
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        int r, max;
        int sv;

        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            r = 0;
            try
            {
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/Visual Studio Project/Visual Studio 2008/student.mdb"; 
                con.Open();
                //MessageBox.Show("connected successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }

        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            try
            {
                r += 1;
                if(r == -1)
                {
                    r += 1;
                }
                if(r == max)
                {
                    btn_R.Enabled = false;
                    btn_L.Enabled = true;
                    MessageBox.Show("No more data entry at row " + (++r));
                }
                if (r < max)
                {
                    txt1.Text = ds.Tables["studentinfo"].Rows[r][0].ToString();
                    txt2.Text = ds.Tables["studentinfo"].Rows[r][1].ToString();
                    txt3.Text = ds.Tables["studentinfo"].Rows[r][2].ToString();
                }
               
            }
            catch(Exception ex)
            {
               MessageBox.Show("error :" + ex.Message);
            }
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            try
            {
                r -= 1;
                if (r == -1)
                {
                    btn_L.Enabled = false;
                    btn_R.Enabled = true;
                    MessageBox.Show("No more data entry at row " + ++r);
                }
                if (r == max)
                {
                    r -= 2;
                }
                if (r <= max)
                {
                    txt1.Text = ds.Tables["studentinfo"].Rows[r][0].ToString();
                    txt2.Text = ds.Tables["studentinfo"].Rows[r][1].ToString();
                    txt3.Text = ds.Tables["studentinfo"].Rows[r][2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }
        }

        private void btn_RM_Click(object sender, EventArgs e)
        {
            r = (max - 1);
            txt1.Text = ds.Tables["studentinfo"].Rows[r][0].ToString();
            txt2.Text = ds.Tables["studentinfo"].Rows[r][1].ToString();
            txt3.Text = ds.Tables["studentinfo"].Rows[r][2].ToString();

            btn_L.Enabled = true;
            btn_R.Enabled = true;
        }

        private void btn_LM_Click(object sender, EventArgs e)
        {
            r = 0;
            txt1.Text = ds.Tables["studentinfo"].Rows[r][0].ToString();
            txt2.Text = ds.Tables["studentinfo"].Rows[r][1].ToString();
            txt3.Text = ds.Tables["studentinfo"].Rows[r][2].ToString();

            btn_L.Enabled = true;
            btn_R.Enabled = true;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            sv = 1;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";

            txt1.Focus();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            sv = 2;
            txt1.ReadOnly = true;
            txt2.Focus();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(sv == 1)
            {
                string st = "insert into studentinfo values (" + txt1.Text + ",'" + txt2.Text + "'," + txt3.Text + ")";
                com = new OleDbCommand(st, con);
                int r = com.ExecuteNonQuery();

                MessageBox.Show(r + " records inserted..!");
            }
            else if(sv == 2)
            {
                string st = "update studentinfo set name='" + txt2.Text + "',marks=" + txt3.Text+" where roll="+txt1.Text;
                com = new OleDbCommand(st, con);
                int r = com.ExecuteNonQuery();

                MessageBox.Show(r + " records updated..!");
            }
            else if(sv == 3)
            {
                string st = "delete from studentinfo where roll=" + txt1.Text;
                com = new OleDbCommand(st, con);
                int r = com.ExecuteNonQuery();

                MessageBox.Show(r + " records deleted..!");
            }   
            else
            {
                MessageBox.Show("Error: during insertion...!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            sv = 3;
            txt1.ReadOnly = true;
            txt2.ReadOnly = true;
            txt3.ReadOnly = true;
        }

        private void btn_Srch_Click(object sender, EventArgs e)
        {
            ds.Clear();
            dt.Clear();
            txt1.ReadOnly = false;
            txt2.ReadOnly = true;
            txt3.ReadOnly = true;
            string st = "select * from studentinfo where roll=" + txt1.Text;
            da = new OleDbDataAdapter(st, con);
            da.Fill(ds, "studentinfo");
            int mm = ds.Tables["studentinfo"].Rows.Count;


            da.Fill(dt);


            if (mm == 1)
            {
                txt2.Text = ds.Tables["studentinfo"].Rows[0][1].ToString();
                txt3.Text = ds.Tables["studentinfo"].Rows[0][2].ToString();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid roll no. ");
                txt2.Text = "";
                txt3.Text = "";
                dt.Clear();
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";

            dt.Clear();
            dataGridView1.DataSource = dt;
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            ds.Clear();
            dt.Clear();
            txt1.ReadOnly = true;
            txt2.ReadOnly = true;
            txt3.ReadOnly = true;

            string st="select * from studentinfo";

            da = new OleDbDataAdapter(st, con);
            // /// using data table (as grid view)
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // ///// using dataset (as in text box)
            da.Fill(ds, "studentinfo");
            max = ds.Tables["studentinfo"].Rows.Count;

            txt1.Text = ds.Tables["studentinfo"].Rows[r][0].ToString();
            txt2.Text = ds.Tables["studentinfo"].Rows[r][1].ToString();
            txt3.Text = ds.Tables["studentinfo"].Rows[r][2].ToString();
        }
    }
}