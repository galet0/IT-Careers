using System;

namespace _04._3_QuickSort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 98, 16, 2, 67, 13, 5, 0 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(", ", arr));
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1); 
                QuickSort(arr, pi + 1, high); 
            }
        }

        public static int Partition(int[] arr,int low,int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high-1; j++)
            {
                if(arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i  + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
