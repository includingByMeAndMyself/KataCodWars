using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata
{
    public class Kata2
    {
        //input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
        //output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }
    }
}
