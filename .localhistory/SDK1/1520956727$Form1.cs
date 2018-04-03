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
                for (int i = 0; i < r.Cells.Count; i++)
                {
                    if(i==0) r.Cells[0].AdjustCellBorderStyle()
                }
            }
        }

        private void dgvSudok_Paint(object sender, PaintEventArgs e)
        {
            int PREFERRED_COLUMN_WIDTH = 3;
            int PREFERRED_ROW_HEIGHT = 3;
            // Override this handler to do custom painting.
            Point currentPoint = new Point(0, 0);
            Size size = new Size(PREFERRED_COLUMN_WIDTH * 3,
                                     PREFERRED_ROW_HEIGHT * 3);
            Pen myPen = new Pen(Color.Red, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    currentPoint.X = i * PREFERRED_ROW_HEIGHT * 3;
                    currentPoint.Y = j * PREFERRED_ROW_HEIGHT * 3;
                    Rectangle rect = new Rectangle(currentPoint, size);
                    e.Graphics.DrawRectangle(myPen, rect);

                }
            }
        }
    }
}
