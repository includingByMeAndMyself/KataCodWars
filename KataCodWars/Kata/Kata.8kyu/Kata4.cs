using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata8kyu
{
    //You get an array of numbers, return the sum of all of the positives ones.

    //    Example [1,-4,7,12] => 1 + 7 + 12 = 20

    //Note: if there is nothing to sum, the sum is default to 0.
    public class Kata4
    {
        public static int PositiveSum(int[] arr)
        {
            // Your code here
            return arr.Where(x => x > 0).Sum();
        }
    }
}
