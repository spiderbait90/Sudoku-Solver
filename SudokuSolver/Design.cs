using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    class Design
    {
        const int cColWidth = 45;
        const int cRowHeigth = 45;
        const int cMaxCell = 9;
        const int cSidelength = cColWidth * cMaxCell + 3;
        private readonly DataGridView dataGridView;

        public Design()
        {
            dataGridView = new DataGridView();
        }

        public DataGridView DataGridView => dataGridView;

        public void CreateDesign()
        {
            dataGridView.Name = "DGV";
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.GridColor = Color.Gray;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.Size = new Size(cSidelength, cSidelength);
            dataGridView.Location = new Point(50, 50);
            dataGridView.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            dataGridView.ForeColor = Color.Black;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;

            for (int i = 0; i < cMaxCell; i++)
            {
                DataGridViewTextBoxColumn TxCol = new DataGridViewTextBoxColumn();
                TxCol.MaxInputLength = 1;
                dataGridView.Columns.Add(TxCol);
                dataGridView.Columns[i].Name = "Col " + (i + 1).ToString();
                dataGridView.Columns[i].Width = cColWidth;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewRow row = new DataGridViewRow();
                row.Height = cRowHeigth;
                dataGridView.Rows.Add(row);
            }

            dataGridView.Columns[2].DividerWidth = 2;
            dataGridView.Columns[5].DividerWidth = 2;
            dataGridView.Rows[2].DividerHeight = 2;
            dataGridView.Rows[5].DividerHeight = 2;
        }

        public void ResetGrid()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = null;
                }
            }
        }
    }
}
