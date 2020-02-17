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
		boolean numberPossible = true;
		int gridBlocks = (int) Math.sqrt(grid.length);
		int blockColumn = blockIndex % gridBlocks;
		int blockRow = (int) Math.floor(blockIndex / gridBlocks);
		
		for(int row = gridBlocks * blockRow; row < (gridBlocks * blockRow) + gridBlocks; row++)
			for(int col = gridBlocks * blockRow; col < (gridBlocks * blockColumn) + gridBlocks; col++)
				if(grid[row][col] == checkNumber) numberPossible = false;

		return numberPossible;
	}
	
	public boolean IsSolved()
	{
		boolean isSolved = true;
		for(int row = 0; row < grid.length; row++)
			for(int col = 0; col < grid.length; col++)
				if(grid[row][col] == 0) isSolved = false;
		
		return isSolved;
	}
}
