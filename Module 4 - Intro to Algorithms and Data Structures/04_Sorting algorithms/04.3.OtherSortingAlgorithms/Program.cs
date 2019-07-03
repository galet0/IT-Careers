using System;
using System.Collections.Generic;

namespace _04._3.ShuffleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 7, 1, 12, 10, 15, 3, 8 };

            Shuffle1(list1);
            Console.WriteLine(string.Join(", ", list1));

        }

        public static void Shuffle1<T>(List<T> source)
        {
            Random rnd = new Random();

            for (int i = 0; i < source.Count; i++)
            {
                // Exchange array[i] with random element in array[i … n-1]

                int r = i + rnd.Next(0, source.Count - i);

                T temp = source[i];
                source[i] = source[r];
                source[r] = temp;
            }
        }

        
    }
}
