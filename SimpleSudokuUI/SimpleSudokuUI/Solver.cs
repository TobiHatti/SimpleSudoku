using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSudokuUI
{
    class Solver
    {
		private int[][] grid = null;

		public Solver(int[][] sudokuGrid)
		{
			this.grid = sudokuGrid;
		}

		public int GetBlock(int row, int column)
		{
			// Test: Does this return the same as the current return!
			//return (int)(Math.Floor((double)row / grid.Length) + Math.Floor(column / Math.Sqrt(grid.Length)));

			return (int)((Math.Floor(row / Math.Sqrt(grid.Length)) * Math.Sqrt(grid.Length)) + Math.Floor(column / Math.Sqrt(grid.Length)));
		}

		public int[][] Solve()
		{
			int[][] workGrid = (int[][])grid.Clone();

			Analyser analyser = new Analyser(workGrid);

			bool changeMade = true;
			int failCtr = 0;
			int[] cellPossibilities;


			while (!analyser.IsSolved() && failCtr < 3)
			{
				changeMade = false;
				for (int row = 0; row < workGrid.Length; row++)
				{
					for (int col = 0; col < workGrid.Length; col++)
					{
						cellPossibilities = CellSolvePosibilities(workGrid, row, col);
						if (cellPossibilities.Length == 1)
						{
							workGrid[row][col] = cellPossibilities[0];
							changeMade = true;
						}
					}
				}

				if (!changeMade) failCtr++;
				if (failCtr >= 3) Console.WriteLine("FailCtr exeeded");
			}

			return workGrid;
		}

		private int[] CellSolvePosibilities(int[][] grid, int row, int column)
		{
			Analyser analyser = new Analyser(grid);
			List<int> validNumbers = new List<int>();

			for (int n = 1; n < grid.Length + 1; n++)
			{
				if (grid[row][column] == 0)
				{
					bool rowCheckOK = analyser.CheckRow(row, n);
					bool columnCheckOK = analyser.CheckColumn(column, n);
					bool blockCheckOK = analyser.CheckBlock(GetBlock(row, column), n);

					if (rowCheckOK && columnCheckOK && blockCheckOK) validNumbers.Add(n);
				}
			}

			return validNumbers.ToArray();
		}

		public int[][] SolveStep()
		{
			return null;
		}

		public int[,,] SolveStepPossibilities(int[][] grid)
		{
			//int[,,] poss = new int[grid.Length,grid.Length,1];

			//for (int row = 0; row < grid.Length; row++)
			//{
			//	for (int col = 0; col < grid.Length; col++)
			//	{
			//		int[] tmp = CellSolvePosibilities(grid, row, col);
			//		for(int i = 0; i < tmp)
			//		poss[row,col]
			//	}
			//}

			//return poss;
			return null;
		}

		public void PrintToConsole(int[][] plotGrid)
		{
			for (int i = 0; i < (plotGrid.Length * 4) + 1; i++) Console.WriteLine("-");
			Console.WriteLine("");

			for (int row = 0; row < plotGrid.Length; row++)
			{
				for (int col = 0; col < plotGrid.Length; col++)
				{
					if (col == 0) Console.WriteLine("| ");
					Console.WriteLine(plotGrid[row][col] + " | ");
				}

				Console.WriteLine("");
				for (int i = 0; i < (plotGrid.Length * 4) + 1; i++) Console.WriteLine("-");
				Console.WriteLine("");
			}
		}
	}
}
