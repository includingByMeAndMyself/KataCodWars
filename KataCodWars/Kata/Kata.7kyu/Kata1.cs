using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KataCodWars.Kata.Kata7kyu
{
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
    public static class Kata1
    {
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
    }
}
