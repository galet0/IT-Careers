using System;

namespace _10_02_01_ReverseElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] reversed = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine(arr.Length);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversed[arr.Length - 1 - i] = arr[i];
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
