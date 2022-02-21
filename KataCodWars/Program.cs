using System;
using System.Collections.Generic;
using System.Linq;
//using KataCodWars.Kata.Kata8kyu;
//using KataCodWars.Kata.Kata7kyu;
using KataCodWars.Kata.Kata6kyu;

namespace KataCodWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Kata5.DeleteNth(new int[] { 1, 2, 3, 2, 3, 1, 3, 3, 2, 2 }, 3))
            {
                Console.WriteLine(item);
            };
        }
    }
}
