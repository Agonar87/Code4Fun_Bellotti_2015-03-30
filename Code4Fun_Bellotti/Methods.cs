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
		/// <returns></returns>
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
    }
}
