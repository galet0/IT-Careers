using System;
using System.Collections.Generic;

namespace _04._3.BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };
            BucketSort(ref array);
            Console.WriteLine(string.Join(", ", array)); 
        }

        public static void BucketSort(ref int[] data)
        {
            int minValue = data[0];
            int maxValue = data[0];

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                if (data[i] < minValue)
                    minValue = data[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < data.Length; i++)
            {
                bucket[data[i] - minValue].Add(data[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        data[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }
    }
}
