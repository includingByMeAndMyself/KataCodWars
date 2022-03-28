using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Kata12
    {
        //public static bool IsPangram(string str)
        //{
        //    return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        //}

        public static bool IsPangram(string str)
        {
            var alph = "abcdefghijklmnopqrstuvwxyz";

            var alphch = alph.ToCharArray();

            str = Regex.Replace(str, "[-.?!)(,:]", "");
            str = string.Join("", str.Where(c => !char.IsDigit(c))).Replace(" ", string.Empty);

            str = new string(str.ToLower().Distinct().OrderBy(x => x).ToArray());

            return alph == str;
        }
    }
}
