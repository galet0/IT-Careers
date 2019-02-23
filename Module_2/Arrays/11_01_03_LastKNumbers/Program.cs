using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_03_LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());//3
            //1 1 2 4 7 13 -> elem
            //0 1 2 3 4 5 -> index-> arr[1] +=  arr[i - 1]
            int[] arr = new int[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)//i - k = -2
            {
                int start = i - k;
                int sum = 0;
                if (start < 0)
                {
                    start = 0;
                }
                for (int j = start; j < i; j++)
                {
                    sum += arr[j];
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
