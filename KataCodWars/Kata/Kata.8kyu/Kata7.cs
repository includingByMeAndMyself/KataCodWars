using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata8kyu
{
    public class Kata7
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null) 
                return new int[] { };
            
            if(input.Length == 0)
                return new int[] { };

            return new[]
            {
                input.Count(x => x > 0),
                input.Where(x => x < 0).Sum(x => x)
            };
        }
    }
}
