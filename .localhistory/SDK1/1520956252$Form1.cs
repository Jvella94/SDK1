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
            BuildBoard();
        }

        private void BuildBoard()
        {
            dgvSudok.ColumnCount = 9;
            string[] row = new string[9];
            int sudokuBoardWidth = 500;
            int sudokuBoardHeight = 500;
            for (int i = 0; i < 9; i++)
            {
                dgvSudok.Rows.Add(row);
            }
            foreach (DataGridViewColumn c in dgvSudok.Columns)
            {
                c.Width = sudokuBoardWidth / dgvSudok.ColumnCount;
            }
            foreach (DataGridViewRow r in dgvSudok.Rows)
            {
                r.Height = sudokuBoardHeight / dgvSudok.RowCount;
            }
            foreach (DataGridViewRow r in dgvSudok.Rows)
            {
                r.Height = 390 / dgvSudok.RowCount;
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            
        }
    }
}
