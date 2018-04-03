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
        }

        private void DgvSudok_Paint(object sender, PaintEventArgs e)
        {

            int sudokuBoardWidth = 500;
            int sudokuBoardHeight = 500;
            int PREFERRED_COLUMN_WIDTH = sudokuBoardWidth / 9;
            int PREFERRED_ROW_HEIGHT = sudokuBoardHeight / 9;
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

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            int[,] sudokuArray = new int[9, 9];
            for (int i = 0; i < dgvSudok.RowCount; i++)
            {
                for (int f = 0; f < dgvSudok.Rows[i].Cells.Count; f++)
                {
                    sudokuArray[i, f] = Convert.ToInt32(dgvSudok.Rows[i].Cells[f].Value);
                }
            }
            for (int i = 0; i < sudokuArray.GetUpperBound(0); i++)
            {
                int[] column = new int[9];
                for (int f = 0; f < 9; f++)
                {
                    column[f] = sudokuArray[f, i];
                }
                int[] distinctColumns = column.Distinct().ToArray();
                if(distinctColumns.Length != column.Length)
                {
                    MessageBox.Show($"Column {i} has a duplicated value.");
                    return;
                }

            }
        }

        private void DgvSudok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int newCellValue = Convert.Toin32(dgvSudok.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            int row = e.RowIndex + 1;
            int column = e.ColumnIndex + 1;
            int boxPositionHeight = 3 * (e.RowIndex    / 3);
            int boxPositionWidth  = 3 * (e.ColumnIndex / 3);
            int[] columnValues = new int[9];
            int[] rowValues = new int[9];
            int[] boxValues = new int[9];
            for (int i = 0; i < dgvSudok.Rows[row-1].Cells.Count; i++)
            {
                rowValues[i] = Convert.ToInt32(dgvSudok.Rows[row - 1].Cells[i].Value);
                int rowValue = Convert.ToInt32(dgvSudok.Rows[row - 1].Cells[i].Value);
                int columnValue = Convert.ToInt32(dgvSudok.Rows[i].Cells[column - 1].Value);
                int boxValue = Convert.ToInt32(dgvSudok.Rows[boxPositionHeight + (i / 3)].Cells[boxPositionWidth + (i % 3)].Value);
                if (newCellValue == rowValue && i != e.ColumnIndex)
                {
                    MessageBox.Show($"Same row value found at position {i} for Cell Value {newCellValue}");
                    return;
                }
                if (newCellValue == columnValue && i != e.ColumnIndex)
                {
                    MessageBox.Show($"Same row value found at position {i} for Cell Value {newCellValue}");
                    return;
                }
                columnValues[i] = Convert.ToInt32(dgvSudok.Rows[i].Cells[column - 1].Value);
                boxValues[i] = Convert.ToInt32(dgvSudok.Rows[boxPositionHeight + (i / 3)].Cells[boxPositionWidth + (i % 3)].Value);

            }
        }
    }
}
