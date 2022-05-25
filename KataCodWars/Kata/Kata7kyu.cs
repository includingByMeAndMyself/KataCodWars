using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace KataCodWars.Kata
{
    public static class Kata7kyu
    {
        #region Kata 1

        //public static string AddBinary(int a, int b) =>
        //    Convert.ToString(a + b, 2);

        public static string AddBinary(int a, int b)
        {
            var stack = new Stack<int>();
            var num = a + b;
            var mod = 0;
            if (num == 0) return "0";

            while (num > 0)
            {
                mod = num % 2;
                stack.Push(mod);
                num /= 2;
            }

            var res = "";
            while (stack.Count > 0)
            {
                res += stack.Pop();
            }
            return res;
        }
        #endregion

        #region Kata 2

        //Джейден Смит, сын Уилла Смита, является звездой таких фильмов, как «Каратэ-пацан» (2010) и «После Земли» (2013).
        //Джейден также известен своей философией, которую он распространяет через Twitter.
        //Когда он пишет в Твиттере, он известен тем, что почти всегда пишет каждое слово с большой буквы.
        //Для простоты вам придется писать каждое слово с заглавной буквы.
        //Посмотрите, какими должны быть сокращения в приведенном ниже примере.


        //Ваша задача состоит в том, чтобы преобразовать строки в то, как они были бы написаны Джейденом Смитом.
        //Строки являются настоящими цитатами Джейдена Смита, но они не написаны с заглавной буквы так, 
        //как он их изначально напечатал.

        //Пример:


        //Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
        //Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

        //public static string ToJadenCase(this string phrase)
        //{
        //    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        //}

        //public static string ToJadenCase(this string phrase)
        //{
        //    return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
        //}

        public static string ToJadenCase(this string phrase)
        {
            var textInfo = new CultureInfo("en-US").TextInfo;
            return textInfo.ToTitleCase(textInfo.ToLower(phrase));
        }
        #endregion

        #region Kata 3

        //Take 2 strings s1 and s2 including only letters from a to z.Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

        //Examples:
        //a = "xyaabbbccccdefww"
        //b = "xxxxyyyyabklmopq"
        //longest(a, b) -> "abcdefklmopqwxy"

        //a = "abcdefghijklmnopqrstuvwxyz"
        //longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

        //public static string Longest(string s1, string s2)
        //{
        //    return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
        //}

        public static string Longest(string s1, string s2)
        {
            var str = (s1 + s2).Distinct().OrderBy(x => x);
            var result = "";
            foreach (var item in str)
            {
                result += item;
            }
            return result;
        }
        #endregion

        #region Kata 4

        //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

        //Example
        //ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => { 1, 2}
        //ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }) => { 1, 2, 0, 15}
        //ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }) => { 1, 2, 231}

        //public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        //{
        //    return listOfItems.OfType<int>();
        //}
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var res = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item.GetType() == typeof(int))
                {
                    res.Add((int)item);
                }
            }
            return res;
        }
        #endregion

        #region Kata 5

        //This time no story, no theory.The examples below show you how to write function accum:

        //Examples:
        //accum("abcd") -> "A-Bb-Ccc-Dddd"
        //accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        //accum("cwAt") -> "C-Ww-Aaa-Tttt"

        //public static String Accum(string s)
        //{
        //    return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        //}
        public static String Accum(string s)
        {
            var value = s.ToLower().ToCharArray();
            string res = null;


            for (int i = 0; i < value.Length; i++)
            {
                res += value[i].ToString().ToUpper();
                var count = 0;
                do
                {
                    if (i == 0) continue;
                    res += value[i];
                    count++;
                } while (count < i);
                res += "-";
            }

            return res.Remove(res.Length - 1);
        }
        #endregion

        #region Kata 6

        //public static bool IsIsogram(string str)
        //{
        //    return str.ToLower().Distinct().Count() == str.Length;
        //}
        public static bool IsIsogram(string str)
        {
            var letters = str.ToLower().ToCharArray().GroupBy(x => x);
            foreach (var letter in letters)
            {
                if (letter.Count() > 1)
                    return false;
            }

            return true;
        }
        #endregion

        #region Kata 7

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
                if (int.TryParse(item.ToString(), out var i))
                {
                    arr.Add(i);
                }
            }

            return arr.Max() + " " + arr.Min();
        }


        //public static int sumTwoSmallestNumbers(int[] numbers)
        //{
        //    return numbers.OrderBy(i => i).Take(2).Sum();
        //}

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers.Length < 1) return 0;

            var firstMin = numbers.Min();

            var secondMin = numbers.Where(x => x != firstMin).Min();

            return secondMin + firstMin;
        } 
        #endregion
    }
}
