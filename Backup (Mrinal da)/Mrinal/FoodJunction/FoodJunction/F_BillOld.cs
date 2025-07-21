using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoodJunction
{
    public partial class F_BillOld : Form
    {
        string  colNam;
        public F_BillOld()
        {
            InitializeComponent();
        }

        private void show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            colNam = dgvshowBills.Columns[dgvshowBills.CurrentCell.ColumnIndex].Name;
            if (colNam=="TabId")
            {
                F_HelpTable TabHelp = new F_HelpTable();
                TabHelp.StartPosition = FormStartPosition.Manual;
                Rectangle loc = this.dgvshowBills.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex,true);

                TabHelp.Location = new Point(loc.Location.X + 4, loc.Location.Y + 120);
                TabHelp.Show();
            }

        }

    
    }
}
