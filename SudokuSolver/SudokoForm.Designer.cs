namespace SudokuSolver
{
    partial class SudokoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SolveIt = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SolveIt
            // 
            this.SolveIt.Location = new System.Drawing.Point(12, 616);
            this.SolveIt.Name = "SolveIt";
            this.SolveIt.Size = new System.Drawing.Size(165, 49);
            this.SolveIt.TabIndex = 1;
            this.SolveIt.Text = "Solve it !";
            this.SolveIt.UseVisualStyleBackColor = true;
            this.SolveIt.Click += new System.EventHandler(this.SolveIt_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(512, 616);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(165, 49);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SudokoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 677);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SolveIt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SudokoForm";
            this.Text = "Sudoku Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SolveIt;
        private System.Windows.Forms.Button Clear;
    }
}

