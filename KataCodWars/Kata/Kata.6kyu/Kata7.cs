using System;
using System.Collections.Generic;
using System.Linq;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Kata7
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            foreach (var number in numbers.GroupBy(c => c).Where(g => g.Count() == 1))
            {
                return number.Key;
            }
            return 0;

            //Best des
            //return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }
    }
}
