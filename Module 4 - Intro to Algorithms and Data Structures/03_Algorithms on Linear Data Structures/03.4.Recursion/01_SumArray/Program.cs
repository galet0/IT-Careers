using System;

namespace _01_SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int sum = Sum(arr, 0);
            Console.WriteLine(sum);
        }

        public static int Sum(int[] arr, int index)
        {
            if(index == arr.Length - 1)
            {
                return arr[index];
            }
            
            return arr[index] + Sum(arr, index + 1);
        }
    }
}
