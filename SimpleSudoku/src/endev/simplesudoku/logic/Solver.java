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
		
		boolean rowCheckOK = false;
		boolean columnCheckOK = false;
		boolean blockCheckOK = false;
		boolean changeMade = true;
		int failCtr = 0;
		
		List<Integer> validNumbers = new ArrayList<Integer>(); 
		
		while(!analyser.IsSolved() && failCtr < 3)
		{
			int j=0;
			changeMade = false;
			for(int row = 0; row < workGrid.length; row++)
			{
				for(int col = 0; col < workGrid.length; col++)
				{
					analyser = new Analyser(workGrid);
					validNumbers = new ArrayList<Integer>(); 
					
					for(int n = 1; n < workGrid.length + 1; n++)
					{		
						if(workGrid[row][col] == 0)
						{
							rowCheckOK = analyser.CheckRow(row, n);
							columnCheckOK = analyser.CheckColumn(col, n);
							blockCheckOK = analyser.CheckBlock(GetBlock(row, col), n);

							if(rowCheckOK && columnCheckOK && blockCheckOK)
							{
								validNumbers.add(n);
								//System.out.println("Can Write " + n + " to Row " + row + " Col " + col + ". Can write a total of " + validNumbers.size());
									
							}
						}
					}
					
					if(validNumbers.size() == 1)
					{
						System.out.println("Wrote " + validNumbers.get(0) + " to Row " + row + " Col " + col);
						workGrid[row][col] = validNumbers.get(0);
						changeMade = true;
					}	
				}
			}

			if(!changeMade) failCtr++;
			if(failCtr >= 3) System.out.println("FailCtr exeeded");
		}	
		
		return workGrid;
	}
	
	public int[][] SolveStep()
	{
		return null;
	}
	
	public int[][][] SolveStepPossibilities()
	{
		return null;
	}
	
	public void PrintToConsole(int[][] plotGrid)
	{
		for(int row = 0; row < plotGrid.length; row++)
		{
			for(int col = 0; col < plotGrid.length; col++)
			{
				System.out.print(plotGrid[row][col] + " | ");
			}

			System.out.println("");
			System.out.println("-----------------------------------");
		}
	}
}
