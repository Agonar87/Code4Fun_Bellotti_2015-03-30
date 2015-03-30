using System;
using System.Collections.Generic;
using Code4Fun_Bellotti;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void Test_CalculateSum()
		{
			//Creating the list of numbers for the multiples
			var multiples = new List<int> {3, 5};

			//Definition of the max value for the iteration
			const int maxValue = 1000;

			//Getting the result
			var result = Methods.Sum(multiples, maxValue);

			//Reporting the result
			Console.Write("The sum of all the multiples of {0} below {1} (excluded) is: {2}", String.Join(" or ", multiples), maxValue, result);
		}
		
		[TestMethod]
		public void Test_PrintSpiral()
		{
			var matrix = new[]
			{ 
				new[] {1, 2, 3, 4}, 
				new[] {5, 6, 7, 8}, 
				new[] {9, 10, 11, 12}, 
				new[] {13, 14, 15, 16}, 
				new[] {17, 18, 19, 20}
			};
			
			//Getting the result
			var result = Methods.PrintSpiral(matrix);
			
			//Asserting result is like the expected (from problems)
			const string expected = "1, 2, 3, 4, 8, 12, 16, 20, 19, 18, 17, 13, 9, 5, 6, 7, 11, 15, 14, 10";
			Assert.IsTrue(expected == result, String.Format("Expected {0}, found {1}", expected, result));

			//Reporting the result
			Console.Write("The matrix printed 'spiral' looks like this: {0}", result);
		}
	}
}
