using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSudokuUI
{
    class Analyser
    {
		private int[][] grid = null;

		public Analyser(int[][] sudokuGrid)
		{
			this.grid = sudokuGrid;
		}

		public bool CheckRow(int rowIndex, int checkNumber)
		{
			bool numberPossible = true;

			for (int i = 0; i < grid.Length; i++)
				if (grid[rowIndex][i] == checkNumber) numberPossible = false;

			return numberPossible;
		}

		public bool CheckColumn(int colIndex, int checkNumber)
		{
			bool numberPossible = true;

			for (int i = 0; i < grid.Length; i++)
				if (grid[i][colIndex] == checkNumber) numberPossible = false;

			return numberPossible;
		}

		public bool CheckBlock(int blockIndex, int checkNumber)
		{
			bool numberPossible = true;
			int gridBlocks = (int)Math.Sqrt(grid.Length);
			int blockColumn = blockIndex % gridBlocks;
			int blockRow = (int)Math.Floor((decimal)blockIndex / gridBlocks);

			for (int row = gridBlocks * blockRow; row < (gridBlocks * blockRow) + gridBlocks; row++)
			{
				for (int col = gridBlocks * blockColumn; col < (gridBlocks * blockColumn) + gridBlocks; col++)
				{
					if (grid[row][col] == checkNumber) numberPossible = false;
				}

			}
			return numberPossible;
		}

		public bool IsSolved()
		{
			bool isSolved = true;
			for (int row = 0; row < grid.Length; row++)
				for (int col = 0; col < grid.Length; col++)
					if (grid[row][col] == 0) isSolved = false;

			return isSolved;
		}
	}
}
