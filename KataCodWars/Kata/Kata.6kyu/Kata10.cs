using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
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
}
