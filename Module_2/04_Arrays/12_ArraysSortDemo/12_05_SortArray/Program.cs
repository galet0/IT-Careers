using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, -11, 35, -3 };
            //1 5 -11 35 -3
            //0 1  2  3   4 -> i
            //  1  2  3   4 -> j
            SortArrayDescending(arr);
            Console.WriteLine(string.Join(" ", arr));
            SortArrayAscending(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void SortArrayDescending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minElemIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minElemIndex])
                    {
                        minElemIndex = j;
                    }
                }

                int swap = arr[i];
                arr[i] = arr[minElemIndex];
                arr[minElemIndex] = swap;
            }
        }

        static void SortArrayAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int maxElemIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[maxElemIndex])
                    {
                        maxElemIndex = j;
                    }
                }

                int swap = arr[i];
                arr[i] = arr[maxElemIndex];
                arr[maxElemIndex] = swap;
            }
        }
    }
}
