using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_SearchElementInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int value = int.Parse(Console.ReadLine());
            bool flag = false;

            int min = 0;
            int max = arr.Length - 1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if(arr[mid] == value)
                {
                    flag = true;
                    break;
                }
                if(value > arr[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
