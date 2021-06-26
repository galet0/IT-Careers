using System;

namespace _03_CombinationsWithRepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            //n=3 => имаме множество от 3 елемента {1, 2, 3}
            int n = 3;
            // k = 2 => 2 nested for-loops
            int k = 2;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = i; j <= n; j++)
            //    {
            //        Console.WriteLine($"{i} {j}");
            //    }
            //}

            int[] array = new int[k];

            Combinations(array, 0, 1, n);
        }

        public static void Combinations(int[] array, int index, int start, int end)
        {
            if(index > array.Length - 1)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i, end);
            }
        }
    }
}
