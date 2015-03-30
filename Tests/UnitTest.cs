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
	}
}
