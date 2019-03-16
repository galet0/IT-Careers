using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02_InsertItemInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 1
            int[] arr = { 1, 2, 3, 7, 9 };
            int item = 12;
            int[] result = new int[arr.Length + 1];
            bool placeNotFound = true;

            for (int i = 0; i < result.Length; i++)
            {
                if((i == result.Length - 1) && placeNotFound)
                {
                    result[i] = item;
                    break;
                }

                if (placeNotFound)
                {
                    if(arr[i] < item)
                    {
                        result[i] = arr[i];
                    }
                    else
                    {
                        result[i] = item;
                        placeNotFound = false;
                    }
                }
                else
                {
                    result[i] = arr[i - 1];
                }

            }
            Console.WriteLine(string.Join(" ",result));

            //Вариант 2
            // копираме от входящия масив в крайния
            Array.Copy(arr, result, arr.Length);
            // последния елемент остава нула, там записваме newValue
            result[result.Length - 1] = item;
            Array.Sort(result);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
