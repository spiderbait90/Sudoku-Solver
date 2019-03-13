using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class SudokoForm : Form
    {
        private string message = "Not Valid Sudoku Puzzle";
        private Design design;
        private Sudoku sudoku;

        public SudokoForm()
        {
            InitializeComponent();
            design = new Design();
            sudoku = new Sudoku(design.DataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            design.CreateDesign();
            Controls.Add(design.DataGridView);
        }

        private void SolveIt_Click(object sender, EventArgs e)
        {
            sudoku.InitializePuzzle(design.DataGridView);

            if (sudoku.IsValid())
            {
                sudoku.SolveSudoku();
                sudoku.ReturnToUserSolvedPuzzle();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            design.ResetGrid();
        }
    }
}
