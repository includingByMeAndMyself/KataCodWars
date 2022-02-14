using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata
{
    public class Kata3
    {
        public static long[] Digitize(long n)
        {
            return n.ToString()
                .Reverse()
                .Select(t => Convert.ToInt64(t.ToString()))
                .ToArray();
        }
    }
}
