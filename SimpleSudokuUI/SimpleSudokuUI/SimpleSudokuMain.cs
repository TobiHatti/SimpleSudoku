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
    // 
    /*
     * MetroForm
     * Office2007Form
     * Office2010Form
     * WorkbookForm
     * AccessoriesForm
     * DraggerForm
     * RibbonForm
     * SfTabbedForm
     * 
     * 
     

         */

    public partial class SimpleSudokuMain : RibbonForm
    {
        public SimpleSudokuMain()
        {
            InitializeComponent();
        }

        private void pbxSudokuGrid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics, 9);
        }

        private void DrawGrid(Graphics g, int size)
        {
            int width = pbxSudokuGrid.Width;
            int height = pbxSudokuGrid.Height;

            float cellWidth = width / size;
            float cellHeight = height / size;

            Pen pen;
            Pen gridPen = new Pen(Color.DarkGray, 2);
            Pen boxPen = new Pen(Color.Black, 6);

            int blockSize = (int)Math.Sqrt(size);

            
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

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            pbxSudokuGrid.Invalidate();
            Debug.Print("Draw");
        }
    }
}
