using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata7kyu
{
    public class Kata5
    {
        //public static bool IsIsogram(string str)
        //{
        //    return str.ToLower().Distinct().Count() == str.Length;
        //}
        public static bool IsIsogram(string str)
        {
            var letters = str.ToLower().ToCharArray().GroupBy(x => x);
            foreach (var letter in letters)
            {
                if (letter.Count() > 1)
                    return false;
            }

            return true;
        }
    }
}
