using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    class Sudoku
    {
        private int[][] puzzle;
        private DataGridView dataGridView;

        public Sudoku(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }

        public int[][] Puzzle => puzzle;

        public bool SolveSudoku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (puzzle[i][j] == 0)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            if (IsPossible(i, j, k, puzzle))
                            {
                                puzzle[i][j] = k;
                                if (SolveSudoku())
                                    return true;
                                else
                                {
                                    puzzle[i][j] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsValid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (puzzle[i][j] != 0)
                    {
                        if (puzzle[i].Count(x => x == puzzle[i][j]) == 2)
                            return false;

                        var countVertical = 0;
                        for (int k = 0; k < 9; k++)
                        {
                            if (puzzle[k][j] == puzzle[i][j])
                            {
                                countVertical++;
                            }
                        }

                        if (countVertical > 1)
                            return false;


                        var countCube = 0;
                        var r = i - i % 3;
                        var c = j - j % 3;

                        for (int a = r; a < r + 3; a++)
                        {
                            for (int b = c; b < c + 3; b++)
                            {
                                if (puzzle[a][b] == puzzle[i][j])
                                    countCube++;
                            }
                        }

                        if (countCube > 1)
                            return false;
                    }
                }
            }

            return true;
        }

        private static bool IsPossible(int row, int col, int number, int[][] puzzle)
        {
            for (int i = 0; i < 9; i++)
            {
                if (puzzle[row][i] == number)
                    return false;
            }

            for (int i = 0; i < 9; i++)
            {
                if (puzzle[i][col] == number)
                    return false;
            }

            var r = row - row % 3;
            var c = col - col % 3;

            for (int i = r; i < r + 3; i++)
            {
                for (int j = c; j < c + 3; j++)
                {
                    if (puzzle[i][j] == number)
                        return false;
                }
            }

            return true;
        }


        public void InitializePuzzle(DataGridView grid)
        {
            var puzzle = new int[9][];

            for (int i = 0; i < 9; i++)
            {
                var arr = new int[9];

                for (int j = 0; j < 9; j++)
                {
                    if (grid.Rows[i].Cells[j].Value != null)
                        arr[j] = int.Parse(grid.Rows[i].Cells[j].Value.ToString());
                    else
                    {
                        arr[j] = 0;
                    }
                }

                puzzle[i] = arr;
            }

            this.puzzle = puzzle;
        }

        public void ReturnToUserSolvedPuzzle()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = puzzle[i][j];
                }
            }
        }
    }
}
