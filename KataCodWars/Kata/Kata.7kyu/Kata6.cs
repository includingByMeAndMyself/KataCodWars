﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata7kyu
{
    public class Kata6
    {
        //public static string HighAndLow(string numbers)
        //{
        //    var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
        //    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
        //}

        public static string HighAndLow(string numbers)
        {
            var arr = new List<int>();
            var nums = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in nums)
            {
                if(int.TryParse(item.ToString(), out var i))
                {
                    arr.Add(i);
                }
            }

            return arr.Max() + " " + arr.Min();
        }
    }
}
