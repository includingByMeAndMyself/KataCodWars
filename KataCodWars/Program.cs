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
            var res = Validator.is_valid_IP("0.0.0.0");
            var res1 = Validator.is_valid_IP("12.255.56.1");
            var res2 = Validator.is_valid_IP("137.255.156.100");

            var res3 = Validator.is_valid_IP("");
            var res4 = Validator.is_valid_IP("abc.def.ghi.jkl");
            var res6 = Validator.is_valid_IP("12.34.56");
            var res5 = Validator.is_valid_IP("123.456.789.0");
            var res7 = Validator.is_valid_IP("123.045.067.089");
            var res8 = Validator.is_valid_IP("12.34.56.-1");
            var res9 = Validator.is_valid_IP("12.34.56 .1");
            var res10 = Validator.is_valid_IP("12.34.56.78sf");
        }
    }
}
