using System;
using System.Collections.Generic;
using System.Linq;

namespace Code4Fun_Bellotti
{
    public static class Methods
    {
		/// <summary>
		/// Calculates the sum of all the multiples
		/// </summary>
		/// <param name="multiples">List of values we have to find the multiples of</param>
		/// <param name="maxValue">Maximum value for the iteration (not included)</param>
		/// <returns>The sum of the values</returns>
	    public static int Sum(List<int> multiples, int maxValue)
	    {
			//Initializing the result
		    var result = 0;

			//Cicle which adds the number only if it is a multiple of a number in the list
		    for (var i = 0; i < maxValue; i++)		    
				result += multiples.Any(x => i % x == 0) ? i : 0;		    

			//Returning result
		    return result;
	    }

		/// <summary>
		/// Unwraps a matrix and prints it in spiral order
		/// </summary>
		/// <param name="matrix">Matrix of elements to print</param>
		/// <returns>A string representing the matrix unwrapped in spiral order</returns>
	    public static string PrintSpiral(int[][] matrix)
	    {
			if(matrix.Length == 0 || 
				matrix.Length == 1 || 
				matrix.First().Length == 0 || 
				matrix.First().Length == 1)
				throw new ArgumentException("Matrix not well formed");

			var result = new List<int>();

		    int startingRowIndex = 0, startingColumnIndex = 0;
		    var endingRow = matrix.Length;
		    var endingColumn = matrix.First().Length;
 
			while (startingRowIndex < endingRow && startingColumnIndex < endingColumn)
			{
				/* Print the first row from the remaining rows */
				int iterator;
				for (iterator = startingColumnIndex; iterator < endingColumn; ++iterator)				
					result.Add(matrix[startingRowIndex][iterator]);
				
				startingRowIndex++;
 
				/* Print the last column from the remaining columns */
				for (iterator = startingRowIndex; iterator < endingRow; ++iterator)				
					result.Add(matrix[iterator][endingColumn-1]);
				
				endingColumn--;
 
				/* Print the last row from the remaining rows */
				if ( startingRowIndex < endingRow)
				{
					for (iterator = endingColumn-1; iterator >= startingColumnIndex; --iterator)					
						result.Add(matrix[endingRow-1][iterator]);
					
					endingRow--;
				}
 
				/* Print the first column from the remaining columns */
				if (startingColumnIndex >= endingColumn) 
					continue;

				for (iterator = endingRow-1; iterator >= startingRowIndex; --iterator)					
					result.Add(matrix[iterator][startingColumnIndex]);
					
				startingColumnIndex++;
			}

		    return String.Join(", ", result);
	    }
    }
}
