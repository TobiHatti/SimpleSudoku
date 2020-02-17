package endev.simplesudoku.logic;

public class Analyser 
{
	private int[][] grid = null;
	
	public Analyser(int[][] sudokuGrid)
	{
		this.grid = sudokuGrid;
	}
	
	public boolean CheckRow(int rowIndex, int checkNumber)
	{
		boolean numberPossible = true;
		
		for(int i = 0; i < grid.length; i++)
			if(grid[rowIndex][i] == checkNumber) numberPossible = false;
		
		return numberPossible;
	}
	
	public boolean CheckColumn(int colIndex, int checkNumber)
	{
		boolean numberPossible = true;
		
		for(int i = 0; i < grid.length; i++)
			if(grid[i][colIndex] == checkNumber) numberPossible = false;
		
		return numberPossible;
	}
	
	public boolean CheckBlock(int blockIndex, int checkNumber)
	{
		int[] block = new int[grid.length];
		
		int gridBlocks = (int) Math.sqrt(grid.length);
		
		int[] blockRows = new int[gridBlocks];
		int[] blockColumns = new int[gridBlocks];
		
		for(int row = 0; row < gridBlocks; row++)
		{
			
			
			for(int col = 0; col < gridBlocks; col++)
			{
				
			}
		}
		
		return null;
	}
	
}
