using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Rank
    {
        public static string NthRank(string st, int[] we, int n)
        {
            var alh = new char[] { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
            var names = st.ToLower().Split(',', StringSplitOptions.TrimEntries);
            var lsNum = new List<int>();

            var num = 0;

            foreach (var name in names)
            {
                foreach (var ch in name.ToCharArray())
                {
                    num += Array.IndexOf(alh, ch) + 1;
                }
                lsNum.Add(num);
                num = 0;
            }

            var arrNum = lsNum.ToArray();

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] *= we[i];
            }

            var names2 = st.Split(',', StringSplitOptions.TrimEntries);

            for (int i = 0; i < names.Length; i++)
            {
                names2[i] = arrNum[i] + " = " + names2[i];
            }

            arrNum = arrNum.OrderBy(x => x).ToArray();

            var r = arrNum[n];

            var res = "";

            foreach (var name in names2)
            {
                if (name.Contains(r.ToString()))
                {
                    res = name;
                }
            }



            return null;
        }
    }
}
