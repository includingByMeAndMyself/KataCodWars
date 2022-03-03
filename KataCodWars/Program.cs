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
            Kata7.GetUnique(new[] { 1, 2, 2, 2 });
            Kata7.GetUnique(new[] { -2, 2, 2, 2 });
            Kata7.GetUnique(new[] { 11, 11, 14, 11, 11 });
        }
    }
}
