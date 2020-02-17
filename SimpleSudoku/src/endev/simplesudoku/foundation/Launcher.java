package endev.simplesudoku.foundation;

import endev.simplesudoku.logic.Analyser;
import endev.simplesudoku.logic.Solver;

public class Launcher 
{
	public static void main(String[] args)
	{
		int [][] sudokuGrid = new int[][] {
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
		
		Analyser analyser = new Analyser(sudokuGrid);	
		
		System.out.println(analyser.CheckRow(0, 8));
		System.out.println(analyser.CheckColumn(8, 8));
		
		Solver solver = new Solver(sudokuGrid);
		
		int[][] result = solver.Solve();
	
			
		
		System.out.println("Done");
		
		solver.PrintToConsole(result);
	}
}
