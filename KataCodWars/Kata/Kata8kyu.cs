using System;
using System.Collections.Generic;
using System.Linq;


namespace KataCodWars.Kata
{
    public class Kata8kyu
    {
        #region Kata 1
        //public class NthSeries
        //{
        //    public static string seriesSum(int n)
        //    {
        //        return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
        //    }
        //}
        public static string SeriesSum(int n)
        {
            double num = 1;
            var count = 0;
            double sum = 0;
            if (n == 0) return "0.00";
            for (var i = 1; count < n; i += 3)
            {
                sum += num / i;
                count++;
            }
            var result = Math.Round(sum, 2).ToString();
            if (result.Length < 4) return result + "0";
            else return result;
        }
        #endregion

        #region Kata 2
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null)
                return new int[] { };

            if (input.Length == 0)
                return new int[] { };

            return new[]
            {
                input.Count(x => x > 0),
                input.Where(x => x < 0).Sum(x => x)
            };
        }
        #endregion

        #region Kata 3
        public static int Litres(double time)
        {
            var count = 0.0;
            for (int i = 0; i < (int)time; i++)
            {
                count += 0.5;
            }
            return (int)count;
        }
        #endregion

        #region Simple, remove the spaces from the string, then return the resultant string
        public class Kata5
        {
            public static string NoSpace(string input)
            {
                return input.Replace(" ", "");
            }
        } 
        #endregion

        #region You get an array of numbers, return the sum of all of the positives ones.

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
        #endregion

        #region Kata 6
        public static long[] Digitize(long n)
        {
            return n.ToString()
                .Reverse()
                .Select(t => Convert.ToInt64(t.ToString()))
                .ToArray();
        }
        #endregion

        #region Kata 7

        //input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
        //output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        } 
        #endregion
    }
}
