using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata7kyu
{
    //This time no story, no theory.The examples below show you how to write function accum:

    //Examples:
    //accum("abcd") -> "A-Bb-Ccc-Dddd"
    //accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    //accum("cwAt") -> "C-Ww-Aaa-Tttt"


    public class Kata4
    {
        //public static String Accum(string s)
        //{
        //    return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        //}
        public static String Accum(string s)
        {
            var value = s.ToLower().ToCharArray();
            string res = null;
           

            for (int i = 0; i < value.Length; i++)
            {
                res += value[i].ToString().ToUpper();
                var count = 0;
                do
                {
                    if(i == 0) continue;
                    res += value[i];
                    count++;
                } while (count < i);
                res += "-";
            }

            return res.Remove(res.Length - 1);
        }
    }
}
