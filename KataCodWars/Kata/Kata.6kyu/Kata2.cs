using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Kata2
    {
        //public static bool IsValidWalk(string[] walk)
        //{
        //    return walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;
        //}

        public static bool IsValidWalk(string[] walk)
        {
            var ns = 0;
            var ew = 0;
            if (walk.Length == 10)
            {
                foreach (var item in walk)
                {
                    if (item == "n") ns++;
                    if (item == "s") ns--;
                    if (item == "w") ew++;
                    if (item == "e") ew--;
                }

                return ns == 0 && ew == 0;
            }
            return false;
        }
    }
}
