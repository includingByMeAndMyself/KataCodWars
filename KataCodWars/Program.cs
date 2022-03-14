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
            var res1 = Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 10);
            var res2 = Xbonacci.Tribonacci(new double[] { 0, 0, 1 }, 10);
            var res3= Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 10);
            
            var res4= Xbonacci.Tribonacci(new double[] { 17, 11, 12 }, 36);
            var res5= Xbonacci.Tribonacci(new double[] { 15, 1, 11 }, 41);
            var res6= Xbonacci.Tribonacci(new double[] { 14, 9, 9 }, 22);
            var res7= Xbonacci.Tribonacci(new double[] { 19, 2, 6 }, 2);
        }
    }
}
