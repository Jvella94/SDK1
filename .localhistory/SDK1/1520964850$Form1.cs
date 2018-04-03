using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread Solver = new Thread(() =>
            {
                bool EndOfArray = true;
                while (EndOfArray)
                {
                    int[,,] fullArray = new int[9, 9, 9];
                    int[,] sudokuArray = new int[9, 9];
                    
                    MethodInvoker methodInvokerChangeValues = delegate ()
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            DataGridViewRow row = dgvSudok.Rows[i];
                            for (int f = 0; f < row.Cells.Count; f++)
                            {
                                sudokuArray[i, f] = Convert.ToInt32(row.Cells[f].Value);

                            }
                        }
                    };
                    if (InvokeRequired) BeginInvoke(methodInvokerChangeValues);
                    else BeginInvoke(methodInvokerChangeValues);
                    bool foundValue = false;

                    for (int i = 0; i < 9; i++)
                    {
                        for (int f = 0; f < 9; f++)
                        {
                            if (CheckCell(sudokuArray, i, f))
                            {
                                foundValue = true;
                                break;
                            }

                        }
                        if (foundValue) break;
                    }
                    if (!foundValue) EndOfArray = false;
                }
            })
            {
                IsBackground = true
            };
            Solver.Start();

        }
        private bool CheckCell(int[,] sudokuArray, int row, int column)
        {
            //int[] columnValues = new int[9];
            //int[] rowValues = new int[9];
            //int[] boxValues = new int[9];
            int[] possibleValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] foundValues = new int[9] ;
            int boxPositionHeight = 3 * (row / 3);
            int boxPositionWidth = 3 * (column / 3);
            for (int i = 0; i < 9; i++)
            {
                int rowValue = Convert.ToInt32(sudokuArray[row,i]);
                int columnValue = Convert.ToInt32(sudokuArray[i,column]);
                int boxValue = Convert.ToInt32(sudokuArray[boxPositionHeight + (i / 3),boxPositionWidth + (i % 3)]);
                if (rowValue != 0) foundValues[rowValue - 1] = 1;
                if (columnValue != 0) foundValues[columnValue - 1] = 1;
                if (boxValue != 0) foundValues[boxValue - 1] = 1;
            }
            int valuesFoundCount = new int();
            for (int i = 0; i < 9; i++)
            {
                if (foundValues[i] == 0) valuesFoundCount++;
            }
            if(valuesFoundCount == 1)
            {
                string PossibleValue = (Array.IndexOf(foundValues, 0) + 1).ToString();
                MethodInvoker methodInvokerChangeValues = delegate ()
                {

                    dgvSudok.Rows[row].Cells[column].Value = PossibleValue;
                }
                    if (InvokeRequired) BeginInvoke(methodInvokerChangeValues);
                else BeginInvoke(methodInvokerChangeValues);
                return true;
            }
            return false;
        }

        private void DgvSudok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSudok.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            int newCellValue = Convert.ToInt32(dgvSudok.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            int row = e.RowIndex + 1;
            int column = e.ColumnIndex + 1;
            int boxPositionHeight = 3 * (e.RowIndex    / 3);
            int boxPositionWidth  = 3 * (e.ColumnIndex / 3);
            int cellBoxPositionRow = new int();
            if (boxPositionHeight == 0)
            {
                cellBoxPositionRow = e.RowIndex;
            }
            else
            {
               cellBoxPositionRow = e.RowIndex % boxPositionHeight;
            }
            int cellBoxPositionColumn = new int();
            if (boxPositionWidth == 0)
            {
                cellBoxPositionColumn = e.ColumnIndex;
            }
            else
            {
                cellBoxPositionColumn = e.ColumnIndex % boxPositionWidth;
            }
            //int[] columnValues = new int[9];
            //int[] rowValues = new int[9];
            //int[] boxValues = new int[9];
            for (int i = 0; i < dgvSudok.Rows[row-1].Cells.Count; i++)
            {
                //rowValues[i] = Convert.ToInt32(dgvSudok.Rows[row - 1].Cells[i].Value);
                //columnValues[i] = Convert.ToInt32(dgvSudok.Rows[i].Cells[column - 1].Value);
                //boxValues[i] = Convert.ToInt32(dgvSudok.Rows[boxPositionHeight + (i / 3)].Cells[boxPositionWidth + (i % 3)].Value);
                int rowValue = Convert.ToInt32(dgvSudok.Rows[row - 1].Cells[i].Value);
                int columnValue = Convert.ToInt32(dgvSudok.Rows[i].Cells[column - 1].Value);
                int boxValue = Convert.ToInt32(dgvSudok.Rows[boxPositionHeight + (i / 3)].Cells[boxPositionWidth + (i % 3)].Value);
                if (newCellValue == rowValue && i != e.ColumnIndex)
                {
                    MessageBox.Show($"Same Row Value found at Position {i + 1} for Cell Value {newCellValue}");
                    dgvSudok.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    return;
                }
                if (newCellValue == columnValue && i != e.RowIndex)
                {
                    MessageBox.Show($"Same Column Value found at Position {i + 1} for Cell Value {newCellValue}");
                    dgvSudok.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    return;
                }
                if (newCellValue == boxValue && i / 3 != cellBoxPositionColumn && i / 3 != cellBoxPositionRow)
                {
                    MessageBox.Show($"Same Box Value found at Position {i + 1} for Cell Value {newCellValue}");
                    dgvSudok.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    return;
                }

            }
        }

        private void DgvSudok_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(DataGridView_KeyPress);
            if (e.Control is TextBox tb)
            {
                tb.KeyPress += new KeyPressEventHandler(DataGridView_KeyPress);
            }

        }

        private void DataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
