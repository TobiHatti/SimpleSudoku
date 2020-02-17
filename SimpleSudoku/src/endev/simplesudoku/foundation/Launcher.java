package endev.simplesudoku.foundation;

import endev.simplesudoku.logic.Analyser;
import endev.simplesudoku.logic.Solver;

public class Launcher 
{
	public static void main(String[] args)
	{
		int [][] sudokuGrid9x9 = new int[][] {
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
		
		int [][] sudokuGrid16x16 = new int[][] {
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

		Solver solver = new Solver(sudokuGrid9x9);
		
		int[][] result = solver.Solve();

		System.out.println("Done");
		
		solver.PrintToConsole(result);
	}
}
