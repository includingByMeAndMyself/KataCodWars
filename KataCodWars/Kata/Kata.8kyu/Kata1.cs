using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata
{
    public class Kata1
    {
        //public class NthSeries
        //{
        //    public static string seriesSum(int n)
        //    {
        //        return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
        //    }
        //}
        public static string seriesSum(int n)
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
    }
}
