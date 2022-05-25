using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataCodWars.Kata
{
    public class Kata6kyu
    {
        #region Kata 1
        public static double Solution(double n) => Math.Round(n * 2) / 2;
        #endregion

        #region Kata 2
        
        //public static string AlphabetPosition(string text)
        //{
        //    return string.Join(" ", text.ToLower()
        //        .Where(c => char.IsLetter(c))
        //        .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
        //        .ToArray());
        //}
        
        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
        #endregion
        
        #region Kata 3

        /*public static int[,] MultiplicationTable(int size)
        {
          var table = new int[size, size];
          var n = Enumerable.Range(1, size).ToList();
          n.ForEach(i => n.ForEach(j => table[i - 1, j - 1] = i * j));
          return table;
        }*/

        public static int[,] MultiplicationTable(int size)
        {
            int[,] res = new int[size, size];

            var count2 = 1;

            for (int i = 0; i < size; i++)
            {
                var count = 1;
                for (int j = 0; j < size; j++)
                {
                    res[i, j] = count * count2;
                    count++;
                }
                count2++;
            }
            return res;
        }
        #endregion

        #region Kata 4

        //public static bool IsPangram(string str)
        //{
        //    return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        //}

        public static bool IsPangram(string str)
        {
            var alph = "abcdefghijklmnopqrstuvwxyz";

            var alphch = alph.ToCharArray();

            str = Regex.Replace(str, "[-.?!)(,:]", "");
            str = string.Join("", str.Where(c => !char.IsDigit(c))).Replace(" ", string.Empty);

            str = new string(str.ToLower().Distinct().OrderBy(x => x).ToArray());

            return alph == str;
        }
        #endregion
        
        #region Kata 5

        //public static bool IsValidWalk(string[] walk)
        //{
        //    return walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;
        //}

        public static bool IsValidWalk(string[] walk)
        {
            var ns = 0;
            var ew = 0;
            if (walk.Length == 10)
            {
                foreach (var item in walk)
                {
                    if (item == "n") ns++;
                    if (item == "s") ns--;
                    if (item == "w") ew++;
                    if (item == "e") ew--;
                }

                return ns == 0 && ew == 0;
            }
            return false;
        }
        #endregion

        #region Kata 6

        //public static int DuplicateCount(string str)
        //{
        //    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        //}
        public static int DuplicateCount(string str)
        {
            var count = 0;
            var letters = str.ToLower().ToCharArray().GroupBy(x => x);
            foreach (var letter in letters)
            {
                if (letter.Count() > 1)
                    count++;
            }
            return count;
        }
        #endregion

        #region Kata 7

        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();
            foreach (var item in arr)
            {
                if (result.Count(i => i == item) < x)
                    result.Add(item);
            }
            return result.ToArray();
        }
        #endregion
        
        #region Kata 8


        //Вы, наверное, знаете систему «лайков» из Facebook и других страниц.Люди могут «лайкать» сообщения в блогах, изображения или другие элементы.
        //Мы хотим создать текст, который должен отображаться рядом с таким элементом.

        //Реализуйте функцию, которая принимает массив, содержащий имена людей, которым понравился элемент.
        //Он должен возвращать отображаемый текст, как показано в примерах:
    
        //  []                                -->  "no one likes this"
        //  ["Peter"]                         -->  "Peter likes this"
        //  ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
        //  ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
        //  ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"

        public static string Likes(string[] name)
        {
            var count = name.Count();
            switch (count)
            {
                case 0:
                    return "no one likes this";

                case 1:
                    return $"{name[0]} likes this";

                case 2:
                    return $"{name[0]} and {name[1]} like this";

                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";

                default:
                    return $"{name[0]}, {name[1]} and {name.Count() - 2} others like this";
            }

        }
        #endregion

        #region Kata 9

        public static int GetUnique(IEnumerable<int> numbers)
        {
            foreach (var number in numbers.GroupBy(c => c).Where(g => g.Count() == 1))
            {
                return number.Key;
            }
            return 0;

            //Best des
            //return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }
        #endregion

        #region Kata 10

        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var res = numbers[i] + numbers[j];
                    if (res == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
        #endregion

        #region Kata 11

        public static string howmuch(int m, int n)
        {
            if (m > n) return howmuch(n, m);

            var result = new StringBuilder("[");

            for (int i = m; i <= n; i++)
            {
                double b = (i - 2) / 7f;
                double c = (i - 1) / 9f;

                if (b % 1 == 0 && c % 1 == 0)
                    result.AppendFormat("[M: {0} B: {1} C: {2}]", i, b, c);
            }
            result.Append(']');

            return result.ToString();
        }
        #endregion

        #region Kata 12

        public static string NthRank(string st, int[] we, int n)
        {
            var alh = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var names = st.ToLower().Split(',', StringSplitOptions.TrimEntries);
            var lsNum = new List<int>();

            var num = 0;

            foreach (var name in names)
            {
                foreach (var ch in name.ToCharArray())
                {
                    num += Array.IndexOf(alh, ch) + 1;
                }
                lsNum.Add(num);
                num = 0;
            }

            var arrNum = lsNum.ToArray();

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] *= we[i];
            }

            var names2 = st.Split(',', StringSplitOptions.TrimEntries);

            for (int i = 0; i < names.Length; i++)
            {
                names2[i] = arrNum[i] + " = " + names2[i];
            }

            arrNum = arrNum.OrderBy(x => x).ToArray();

            var r = arrNum[n];

            var res = "";

            foreach (var name in names2)
            {
                if (name.Contains(r.ToString()))
                {
                    res = name;
                }
            }

            return null;
        }
        #endregion

        #region Kata 13

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
            var arr = new long[b - a + 1];
            var res = new List<long>();

            for (long i = 0; i < arr.Length; i++)
            {
                arr[i] = c;
                c++;
            }


            for (long i = 0; i < arr.Length; i++)
            {
                if (arr[i] == CheckConsecutivePowerRes(arr[i]))
                {
                    res.Add(arr[i]);
                }
            }

            if (res.Count == 0) return new long[0];

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
        #endregion

        #region Kata 14

        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
                return null;
            var ts = TimeSpan.FromSeconds((g * 3600) / (v2 - v1));
            return new[] { ts.Hours, ts.Minutes, ts.Seconds };
        }
        #endregion

        #region Kata 15

        public static string[] TowerBuilder(int nFloors)
        {
            if (nFloors == 0) return null;

            if (nFloors == 1) return new string[] { "*" };

            var arr = new string[nFloors];
            var floor = "";

            for (int i = 0; i < nFloors; i++)
            {
                var stars = new String('*', i * 2 + 1);
                var spaces = new String(' ', nFloors - i - 1);
                floor = spaces.ToString() + stars + spaces;
                arr[i] = floor;
            }

            return arr;
        }
        #endregion

        #region Kata 16

        //public static bool is_valid_IP(string IpAddres)
        //{
        //    IPAddress ip;
        //    bool validIp = IPAddress.TryParse(IpAddres, out ip);
        //    return validIp && ip.ToString() == IpAddres;
        //}


        //public static bool is_valid_IP(string IpAddres)
        //{
        //    var octet = "([1-9][0-9]{0,2})";
        //    var reg = $@"{octet}\.{octet}\.{octet}\.{octet}";
        //    return new Regex(reg).IsMatch(IpAddres);
        //}

        public static bool is_valid_IP(string ipAddres)
        {
            if (string.IsNullOrWhiteSpace(ipAddres))
                return false;

            var numbs = ipAddres.Split('.');

            if (numbs.Length != 4)
                return false;

            foreach (var num in numbs)
            {
                if (num.IndexOf(' ') >= 0)
                    return false;

                if (num.StartsWith("0") && num.Length > 1)
                    return false;

                if (!int.TryParse(num, out int obj))
                    return false;

                if (obj > 255 || obj < 0)
                    return false;
            }

            return true;
        }
        #endregion

        #region Kata 17
        
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
        #endregion
    }

    #region Kata 

    //Linked Lists - Length & Count

    //Implement Length() to count the number of nodes in a linked list.

    //Node.Length(nullptr) => 0
    //Node.Length(1 -> 2 -> 3 -> nullptr) => 3
    //Implement Count() to count the occurrences of a that satisfy a condition provided by a predicate which takes in a node's Data value.

    //Node.Count(null, value => value == 1) => 0
    //Node.Count(1 -> 3 -> 5 -> 6, value => value % 2 != 0) => 3
    //I've decided to bundle these two functions within the same Kata since they are both very similar.
    public class Noda
    {
        public int Data;
        public Noda Next;

        public Noda(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static int Length(Noda head)
        {
            var length = 0;
            while (head != null)
            {
                length += 1;
                head = head.Next;
            }
            return length;
        }

        public static int Count(Noda head, Predicate<int> func)
        {
            var node = head;
            var count = 0;
            while (node != null)
            {
                if (func(node.Data))
                {
                    count += 1;
                }
                node = node.Next;
            }
            return count;
        }
    } 
    #endregion
}
