using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleSudokuUI
{
    public partial class SimpleSudokuMain : RibbonForm
    {
        int[][] SudokuGrid = new int[][] {
            new int[] { 3,0,0,6,0,0,0,9,0 },
            new int[] { 0,4,0,0,2,0,0,5,0 },
            new int[] { 0,8,0,0,7,0,1,6,0 },
            new int[] { 9,0,0,3,0,4,7,0,0 },
            new int[] { 0,5,0,0,8,0,0,2,0 },
            new int[] { 0,0,1,9,0,0,0,0,6 },
            new int[] { 0,2,7,0,3,0,0,4,0 },
            new int[] { 0,9,0,0,6,0,0,1,0 },
            new int[] { 0,3,0,0,0,5,0,0,8 }
        };

        int[][] SudokuGrid2 = new int[][] {
            new int[] {  1, 0, 0, 2, 3, 4, 0, 0,12, 0, 6, 0, 0, 0, 7, 0 },
            new int[] {  0, 0, 8, 0, 0, 0, 7, 0, 0, 3, 0, 0, 9,10, 6,11 },
            new int[] {  0,12, 0, 0,10, 0, 0, 1, 0,13, 0,11, 0, 0,14, 0 },
            new int[] {  3, 0, 0,15, 2, 0, 0,14, 0, 0, 0, 9, 0, 0,12, 0 },
            new int[] { 13, 0, 0, 0, 8, 0, 0,10, 0,12, 2, 0, 1,15, 0, 0 },
            new int[] {  0,11, 7, 6, 0, 0, 0,16, 0, 0, 0,15, 0, 0, 5,13 },
            new int[] {  0, 0, 0,10, 0, 5,15, 0, 0, 4, 0, 8, 0, 0,11, 0 },
            new int[] { 16, 0, 0, 5, 9,12, 0, 0, 1, 0, 0, 0, 0, 0, 8, 0 },
            new int[] {  0, 2, 0, 0, 0, 0, 0,13, 0, 0,12, 5, 8, 0, 0, 3 },
            new int[] {  0,13, 0, 0,15, 0, 3, 0, 0,14, 8, 0,16, 0, 0, 0 },
            new int[] {  5, 8, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0,13, 9,15, 0 },
            new int[] {  0, 0,12, 4, 0, 6,16, 0,13, 0, 0, 7, 0, 0, 0, 5 },
            new int[] {  0, 3, 0, 0,12, 0, 0, 0, 6, 0, 0, 4,11, 0, 0,16 },
            new int[] {  0, 7, 0, 0,16, 0, 5, 0,14, 0, 0, 1, 0, 0, 2, 0 },
            new int[] { 11, 1,15, 9, 0, 0,13, 0, 0, 2, 0, 0, 0,14, 0, 0 },
            new int[] {  0,14, 0, 0, 0,11, 0, 2, 0, 0,13, 3, 5, 0, 0,12 }
        };

        public SimpleSudokuMain()
        {
            InitializeComponent();
        }

        private float GetCellWidth(int pGridSize) => pbxSudokuGrid.Width / SudokuGrid.Length;
        private float GetCellHeight(int pGridSize) => pbxSudokuGrid.Width / SudokuGrid.Length;

        private void pbxSudokuGrid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics, SudokuGrid.Length);
            FillNumbers(e.Graphics, SudokuGrid);
        }

        private void DrawGrid(Graphics g, int size)
        {
            int width = pbxSudokuGrid.Width;
            int height = pbxSudokuGrid.Height;

            float cellWidth = GetCellWidth(size);
            float cellHeight = GetCellHeight(size);

            int blockSize = (int)Math.Sqrt(size);

            Pen gridPen = new Pen(Color.DarkGray, 2);
            Pen boxPen = new Pen(Color.Black, 6);
            
            // Draw inner (dense) grid
            for (int i = 1; i < size; i++)
            {
                if (i % blockSize != 0)
                {
                    g.DrawLine(gridPen, new PointF(0, i * cellWidth), new PointF(height, i * cellWidth));
                    g.DrawLine(gridPen, new PointF(i * cellHeight, 0), new PointF(i * cellHeight, width));
                }
            }

            // Draw inner box-grid
            for (int i = 1; i < size; i++)
            {
                if (i % blockSize == 0)
                {
                    g.DrawLine(boxPen, new PointF(0, i * cellWidth), new PointF(height, i * cellWidth));
                    g.DrawLine(boxPen, new PointF(i * cellHeight, 0), new PointF(i * cellHeight, width));
                }               
            }

            // Draw border
            g.DrawRectangle(boxPen, 0, 0, width, height);
        }

        // Fills numbers with 1 possibility
        private void FillNumbers(Graphics g, int[][] sudokuGrid)
        {
            int fontSize = 0;
            int numberOffsetX = 0;
            int numberOffsetY = 0;

            switch(sudokuGrid.Length)
            {
                case 9:
                    fontSize = 30;
                    numberOffsetX = 11;
                    numberOffsetY = 4;
                    break;
                case 16:
                    fontSize = 17;
                    numberOffsetX = 0;
                    numberOffsetY = 0;
                    break;
            }

            for(int row = 0; row < sudokuGrid.Length; row++)
            {
                for(int col = 0; col < sudokuGrid[row].Length; col++)
                {
                    if (sudokuGrid[row][col] != 0)
                    {
                        g.DrawString(
                            Convert.ToString(sudokuGrid[row][col]),
                            new Font("Calibri", fontSize),
                            Brushes.Black,
                            new PointF(numberOffsetX + GetCellWidth(sudokuGrid.Length) * col, numberOffsetY + GetCellHeight(sudokuGrid.Length) * row)
                        );
                    }
                }
            }
        }

        // Fills numbers with multible possibilities
        private void FillNumbers(Graphics g, int[][][] sudokuGrid)
        {
            
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            pbxSudokuGrid.Invalidate();
            Debug.Print("Draw");
        }
    }
}
