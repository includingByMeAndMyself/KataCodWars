using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public static class Xbonacci
    {

        // Best Practices

        //public double[] Tribonacci(double[] s, int n)
        //{
        //    double[] res = new double[n];
        //    Array.Copy(s, res, Math.Min(3, n));

        //    for (int i = 3; i < n; i++)
        //        res[i] = res[i - 3] + res[i - 2] + res[i - 1];

        //    return n == 0 ? new double[] { 0 } : res;
        //}


        //public double[] Tribonacci(double[] signature, int n)
        //{
        //    var seq = new List<double>(signature);

        //    for (var i = 3; i < n; i++)
        //    {
        //        seq.Add(seq[i - 1] + seq[i - 2] + seq[i - 3]);
        //    }

        //    return seq.Take(n).ToArray();
        //}

        //решение рожденное за минуту
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0) return new double[] { };

            var a = signature[0];
            var b = signature[1];
            var c = signature[2];
            var res = new double[n];

            res[0] = a;

            if (n == 1) return res;

            res[1] = b;
            if (n == 2) return res;

            res[2] = c;

            var f = 0;
            var j = 1;
            var g = 2;

            for (int i = 3; i < n; i++)
            {
                res[i] = res[f] + res[j] + res[g];
                f++;
                j++;
                g++;
            }

            return res;
        }


        //public double[] xbonacci(double[] signature, int n)
        //{
        //    var sequence = new List<double>(signature);
        //    int count = signature.Length;
        //    for (int i = count; i < n; i++)
        //        sequence.Add(sequence.Skip(i - count).Take(count).Sum());
        //    return sequence.Take(n).ToArray();
        //}

        public static double[] xbonacci(double[] s, int n)
        {
            double[] res = new double[n];

            Array.Copy(s, res, Math.Min(s.Length, n));

            for (int i = s.Length; i < n; i++)
            {
                var count = s.Length;

                while (count > 0)
                {
                    res[i] += res[i - count];
                    count--;
                }
            }

            return n == 0 ? new double[] { } : res;
        }
    }
}
