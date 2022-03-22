using System;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Kata11
    {
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
    }
}
