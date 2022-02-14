using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata7kyu
{
    //Take 2 strings s1 and s2 including only letters from a to z.Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

    //Examples:
    //a = "xyaabbbccccdefww"
    //b = "xxxxyyyyabklmopq"
    //longest(a, b) -> "abcdefklmopqwxy"

    //a = "abcdefghijklmnopqrstuvwxyz"
    //longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
    public class Kata2
    {
        //public static string Longest(string s1, string s2)
        //{
        //    return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
        //}
        public static string Longest(string s1, string s2)
        {
            var str = (s1 + s2).Distinct().OrderBy(x => x);
            var result = "";
            foreach (var item in str)
            {
                result += item;
            }
            return result;
        }
    }
}
