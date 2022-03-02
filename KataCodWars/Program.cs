using System;
using System.Collections.Generic;
using System.Linq;
using KataCodWars.Kata.Kata8kyu;
//using KataCodWars.Kata.Kata7kyu;
//using KataCodWars.Kata.Kata6kyu;

namespace KataCodWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 };
            var arr2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            
            Kata7.CountPositivesSumNegatives(arr1);
            Kata7.CountPositivesSumNegatives(arr2);
            Kata7.CountPositivesSumNegatives(null);
            Kata7.CountPositivesSumNegatives(new int[] { });
        }
    }
}
