package endev.simplesudoku.logic;
import java.util.*; 

public class Solver 
{
	private int[][] grid = null; 
	
	public Solver(int[][] sudokuGrid)
	{
		this.grid = sudokuGrid;
	}
	
	public int GetBlock(int row, int column)
	{
		return (int) ((Math.floor(row / Math.sqrt(grid.length)) * Math.sqrt(grid.length)) + Math.floor(column / Math.sqrt(grid.length)));
	}
	
	public int[][] Solve()
	{
		int[][] workGrid = grid.clone();
		
		Analyser analyser = new Analyser(workGrid);
		
		boolean changeMade = true;
		int failCtr = 0;
		int[] cellPossibilities;
	
		
		while(!analyser.IsSolved() && failCtr < 3)
		{
			changeMade = false;
			for(int row = 0; row < workGrid.length; row++)
			{
				for(int col = 0; col < workGrid.length; col++)
				{		
					cellPossibilities = CellSolvePosibilities(workGrid, row, col);
					if(cellPossibilities.length == 1)
					{
						workGrid[row][col] = cellPossibilities[0];
						changeMade = true;
					}	
				}
			}

			if(!changeMade) failCtr++;
			if(failCtr >= 3) System.out.println("FailCtr exeeded");
		}	
		
		return workGrid;
	}
	
	private int[] CellSolvePosibilities(int[][] grid, int row, int column)
	{
		Analyser analyser = new Analyser(grid);
		List<Integer> validNumbers = new ArrayList<Integer>(); 
		
		for(int n = 1; n < grid.length + 1; n++)
		{		
			if(grid[row][column] == 0)
			{
				boolean rowCheckOK = analyser.CheckRow(row, n);
				boolean columnCheckOK = analyser.CheckColumn(column, n);
				boolean blockCheckOK = analyser.CheckBlock(GetBlock(row, column), n);

				if(rowCheckOK && columnCheckOK && blockCheckOK) validNumbers.add(n);
			}
		}
		
		return validNumbers.stream().mapToInt(i->i).toArray();
	}
	
	public int[][] SolveStep()
	{
		return null;
	}
	
	public int[][][] SolveStepPossibilities(int[][] grid)
	{
		int[][][] poss = new int[grid.length][grid.length][1];
		
		for(int row = 0; row < grid.length; row++)
		{
			for(int col = 0; col < grid.length; col++)
			{	
				poss[row][col] = CellSolvePosibilities(grid, row, col);
			}
		}
		
		return poss;
	}
	
	public void PrintToConsole(int[][] plotGrid)
	{
		for(int i = 0; i < (plotGrid.length * 4) + 1; i++) System.out.print("-");
		System.out.println("");
		
		for(int row = 0; row < plotGrid.length; row++)
		{
			for(int col = 0; col < plotGrid.length; col++)
			{
				if(col == 0) System.out.print("| ");
				System.out.print(plotGrid[row][col] + " | ");
			}

			System.out.println("");
			for(int i = 0; i < (plotGrid.length * 4) + 1; i++) System.out.print("-");
			System.out.println("");
		}
	}
}
