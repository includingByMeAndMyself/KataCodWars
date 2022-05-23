using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata7kyu
{
    public class Binary
    {

        //public static string AddBinary(int a, int b) =>
        //    Convert.ToString(a + b, 2);

        public static string AddBinary(int a, int b)
        {
            var stack = new Stack<int>();
            var num = a + b;
            var mod = 0;
            if (num == 0) return "0";

            while (num > 0)
            {
                mod = num % 2;
                stack.Push(mod);
                num /= 2;
            }

            var res = "";
            while(stack.Count > 0)
            {
                res+=stack.Pop();
            }
            return res;
        }
    }
}
