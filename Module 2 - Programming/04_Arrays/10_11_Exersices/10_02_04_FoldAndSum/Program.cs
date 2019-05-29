using System;
using System.Linq;

namespace _10_02_04_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {   //0 1 2 3 4 5 6 7 -> indexes
            //1 2 3 4 5 6 7 8 -> elements
            //    0 1 2 3 -> indexes
            //    2 1 8 7 -> upper
            //    3 4 5 6 -> lower
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();//{ 1, 2, 3, 4, 5, 6, 7, 8 };

            int k = numbers.Length / 4; // k = 2
            int length = k * 2;
            int[] upperArray = new int[length]; // upper -> 4 elements
            int[] lowerArray = new int[length]; // lower -> 4 elements

            for (int i = 0; i < k; i++)
            {
                upperArray[i] = numbers[k - i - 1];
                upperArray[upperArray.Length - 1 - i] = numbers[numbers.Length - k + i];//8 - k + i -> 8 - 2 + 1
            }
            for (int i = 0; i < length; i++)
            {
                lowerArray[i] = numbers[k + i];
            }
            Console.WriteLine(string.Join(" ", upperArray));
            Console.WriteLine(string.Join(" ", lowerArray));

            int[] sum = new int[length];
            for (int i = 0; i < length; i++)
            {
                sum[i] = upperArray[i] + lowerArray[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
