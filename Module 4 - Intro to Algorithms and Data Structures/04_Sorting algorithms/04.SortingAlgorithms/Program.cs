using System;
using System.Collections.Generic;

namespace _04.SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 12, 8, 10, 2, 9, 6, 1};
            //SelectionSort(list);
            Console.WriteLine(string.Join(", ", list));

            //BubbleSortWithWhile(list);
            Console.WriteLine(string.Join(", ", list));

            BubbleSortWithFor(list);
            Console.WriteLine(string.Join(", ", list));

        }

        public static void SelectionSort(List<int> list)
        {
            for (int index = 0; index < list.Count; index++)
            {
                int min = index;
                for (int current = index + 1; current < list.Count; current++)
                {
                    if(list[current] < list[min])
                    {
                        min = current;
                    }
                }

                Swap(list, index, min);
            }
            
        }

        public static void BubbleSortWithWhile(List<int> list)
        {
            bool swap = true;

            while (swap)
            {
                swap = false;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        Swap(list, i, i + 1);
                        swap = true;
                    }
                }
            }
        }

        public static void BubbleSortWithFor(List<int> list)
        {
            for (int j = 0; j <= list.Count - 2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        Swap(list, i, i + 1);
                    }
                }
            }
        }

        public static void InsertionSort(List<int> list)
        {
            for (int i = 1; i < list.Count; ++i)
            {
                int key = list[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }

        private static void Swap(List<int> list, int index, int min)
        {
            int temp = list[index];
            list[index] = list[min];
            list[min] = temp;
        }
    }
}
