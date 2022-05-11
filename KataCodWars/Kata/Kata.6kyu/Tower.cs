using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public static class Tower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            if(nFloors == 0) return null;

            if(nFloors == 1) return new string[] { "*" };

            var arr = new string[nFloors];
            var floor = "";

            for (int i = 0; i < nFloors; i++)
            {
                var stars = new String('*', i * 2 + 1);
                var spaces = new String(' ', nFloors - i - 1);
                floor = spaces.ToString() + stars + spaces;
                arr[i] = floor;
            }

             
            return arr;
        }
    }
}
