using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public class SumDigPower
    {
        /*сумма дает одно и то же число.

        В результате:89 = 8^1 + 9^2

        Следующим числом обладающего этим свойством является 135.

        Посмотрите это свойство еще раз:135 = 1^1 + 3^2 + 5^3

        Нам нужна функция для сбора этих чисел, которая может принимать два целых числа a, bкоторая определяет диапазон [a, b](включительно) и выводит список отсортированных чисел в диапазоне, удовлетворяющем описанному выше свойству.

        Давайте рассмотрим некоторые случаи:

        sum_dig_pow(1, 10) == [1, 2, 3, 4, 5, 6, 7, 8, 9]

        sum_dig_pow(1, 100) == [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]*/


        /*  public static long[] SumDigPow(long a, long b)
        {
            return Enumerable.Range((int) a, (int) (b - a))
                .Where(x => (long) x.ToString().Select((c, i) => Math.Pow(c - '0', i + 1)).Sum() == x)
                .Select(Convert.ToInt64).ToArray();
        }*/


        /*public static long[] SumDigPow(long a, long b) 
        {
            List<long> values = new List<long>();
            for (long x = a; x <= b; x++)
            {
              if (x.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == x)
                values.Add(x);
            }
            return values.ToArray();
        }*/

        public static long[] SumDigPow(long a, long b)
        {
            var c = a;
            var arr = new long[b-a+1];
            var res = new List<long>();

            for (long i = 0; i < arr.Length; i++)
            {
                arr[i] = c;
                c++;
            }
                

            for ( long i = 0; i < arr.Length; i++)
            {
                if(arr[i] == CheckConsecutivePowerRes(arr[i]))
                {
                    res.Add(arr[i]);
                }
            }

            if(res.Count == 0) return new long[0];

            return res.ToArray();
        }

        private static long CheckConsecutivePowerRes(long v)
        {
            string str = v.ToString();
            long[] numbers = str.Select(x => long.Parse(x.ToString())).ToArray();
            double res = 0;
            var pow = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                res += Math.Pow(numbers[i], pow);
                pow++;
            }
            return (long)res;
        }
    }
}
