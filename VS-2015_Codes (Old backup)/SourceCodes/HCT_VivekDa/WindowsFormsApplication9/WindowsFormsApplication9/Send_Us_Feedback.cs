using System;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Send_Us_Feedback : Form
    {
        public Send_Us_Feedback()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select all the areas");
            }

            else if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Please select all the areas");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Please select all the areas");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {

                MessageBox.Show("Please select all the areas");
            }
            else
            {
                MessageBox.Show("Thank you so much !" + Environment.NewLine + "Your suggestions are highly appreciated ! " );
                this.Close();
            }

        }

    }
}
