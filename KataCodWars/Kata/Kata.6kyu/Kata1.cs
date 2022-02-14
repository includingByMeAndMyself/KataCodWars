using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Kata1
    {
        //public static string AlphabetPosition(string text)
        //{
        //    return string.Join(" ", text.ToLower()
        //        .Where(c => char.IsLetter(c))
        //        .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
        //        .ToArray());
        //}
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
