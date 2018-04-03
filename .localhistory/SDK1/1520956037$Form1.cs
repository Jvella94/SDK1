using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDK1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            int rowAmount = Convert.ToInt32(tBxRow.Text);
            int columnAmount = Convert.ToInt32(tBxColumns.Text);
            dgvSudok.ColumnCount = columnAmount * 3;
            string[] row = new string[rowAmount * 3];
            for (int i = 0; i < rowAmount*3; i++)
            {
                dgvSudok.Rows.Add(row);
            }
            foreach (DataGridViewColumn c in dgvSudok.Columns)
            {
                c.Width = 770 / dgvSudok.ColumnCount;
            }
            foreach (DataGridViewRow r in dgvSudok.Rows)
            {
                r.Height = 390 / dgvSudok.RowCount;
            }
        }
    }
}
