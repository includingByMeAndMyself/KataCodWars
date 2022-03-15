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
            var res1 = Xbonacci.xbonacci(new double[] { 0, 1 }, 10);
            var res2 = Xbonacci.xbonacci(new double[] { 1, 1 }, 10);
            var res3= Xbonacci.xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10);
            
            var res4= Xbonacci.xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10);
            var res5= Xbonacci.xbonacci(new double[] { 15, 0, 2, 19, 5, 0, 13, 0, 5, 7, 2, 8, 9, 10, 3, 16 }, 55);
        }
    }
}
