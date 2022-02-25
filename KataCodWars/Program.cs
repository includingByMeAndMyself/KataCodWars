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
            Console.WriteLine(Kata6.Likes(new string[0]));
            Console.WriteLine(Kata6.Likes(new string[] { "Peter" }));
            Console.WriteLine(Kata6.Likes(new string[] { "Jacob", "Alex" }));
            Console.WriteLine(Kata6.Likes(new string[] { "Max", "John", "Mark" }));
            Console.WriteLine(Kata6.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
            Console.WriteLine(Kata6.Likes(new string[] { "Alex", "Jacob", "Mark", "Max", "Nike" }));
        }
    }
}
