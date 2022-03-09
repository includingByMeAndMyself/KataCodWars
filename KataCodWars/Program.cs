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
            foreach (var arg in Kata8.TwoSum(new[] { 1, 2, 3 }, 4))
            {
                Console.Write(arg);
                Console.Write(" ");
            }

            foreach (var arg in Kata8.TwoSum(new[] { 1234, 5678, 9012 }, 14690))
            {
                Console.Write(arg);
                Console.Write(" ");
            }

            foreach (var arg in Kata8.TwoSum(new[] { 2, 2, 3 }, 4))
            {
                Console.Write(arg);
                Console.Write(" ");
            }
            
            
        }
    }
}
