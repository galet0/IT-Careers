using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BubbleSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Метод на мехурчето
            //обхождане от първия до последния елемент и сравняваме два съседни 
            // 0  1  2   3  4
            int[] arr = { 2, 4, -5, 1, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
