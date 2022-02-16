using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata8kyu
{
    public class Kata6
    {
        public static int Litres(double time)
        {
            var count = 0.0;
            for (int i = 0; i < (int)time; i++)
            {
                count+=0.5;
            }
            return (int)count;
        }
    }
}
