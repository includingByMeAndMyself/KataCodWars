using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    //Вы, наверное, знаете систему «лайков» из Facebook и других страниц.Люди могут «лайкать» сообщения в блогах, изображения или другие элементы.
    //Мы хотим создать текст, который должен отображаться рядом с таким элементом.

    //Реализуйте функцию, которая принимает массив, содержащий имена людей, которым понравился элемент.
    //Он должен возвращать отображаемый текст, как показано в примерах:
    
    //  []                                -->  "no one likes this"
    //  ["Peter"]                         -->  "Peter likes this"
    //  ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
    //  ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
    //  ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
    public class Kata6
    {
        public static string Likes(string[] name)
        {
            var count = name.Count();
            switch (count)
            {
                case 0:
                    return "no one likes this";
                    break;
                case 1:
                    return $"{name[0]} likes this";
                    break;
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                    break;
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                    break;
                default:
                    return $"{name[0]}, {name[1]} and {name.Count() - 2} others like this";
                    break;
            }

        }
    }
}
