using System;
using System.Collections.Generic;
using System.Linq;
//using KataCodWars.Kata.Kata8kyu;
//using KataCodWars.Kata.Kata7kyu;
using KataCodWars.Kata.Kata6kyu;

namespace KataCodWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var res1 = SumDigPower.SumDigPow(1, 10);
            var res2 = SumDigPower.SumDigPow(1, 100);
            var res3 = SumDigPower.SumDigPow(10, 100);
            var res4 = SumDigPower.SumDigPow(90, 100);
            var res5 = SumDigPower.SumDigPow(90, 150);
        }
    }
}
