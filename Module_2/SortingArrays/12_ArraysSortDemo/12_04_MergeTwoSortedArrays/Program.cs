using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_MergeTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < arr1.Length && j < arr2.Length)
            {
                if(arr1[i] < arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                    k++;
                }
            }

            while(i < arr1.Length)
            {
                result[k] = arr1[i];
                i++;
                k++;
            }

            while(j < arr2.Length)
            {
                result[k] = arr2[j];
                j++;
                k++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
