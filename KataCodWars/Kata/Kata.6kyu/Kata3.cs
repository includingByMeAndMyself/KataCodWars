using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Kata3
    {
        //public static int DuplicateCount(string str)
        //{
        //    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        //}
        public static int DuplicateCount(string str)
        {
            var count = 0;
            var letters = str.ToLower().ToCharArray().GroupBy(x => x);
            foreach (var letter in letters)
            {
                if (letter.Count() > 1)
                    count++;
            }
            return count;
        }
    }
}
