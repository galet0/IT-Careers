using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_02_LongestSequenceIdenticalItems
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Вариант 1
             * 100/ 100 - > 1 2 3 4 - Expected -> 1, MyPutput -> 2
            //0  1  2  3  4  5  6  7  8  9
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); //{ 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int start = 0;
            int length = 1;
            int pos = 1;
            int digit = 0;
            int maxLength = 0;
            for (int i = pos; i < arr.Length; i++)
            {                
                if (arr[pos] == arr[start])
                {
                    length++;
                }
                else
                {
                    start = pos;
                    length = 1;
                }
                if (maxLength < length)
                {
                    maxLength = length;
                    digit = arr[start];
                }
                pos++;
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
            */
            /*Вариант 2*/
            /*int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 1;
            int digit = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentIndex = arr[i];
                int longest = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if(currentIndex == arr[j])
                    {
                        longest++;
                        if (max < longest)
                        {
                            max = longest;
                            digit = currentIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }

            for (int i = 0; i < max; i++)
            {
                Console.Write($"{digit} ");
            }*/

            //Вариант 3

            /*int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestLength = 1;
            int longestStart = 0;
            int currentLength = 1;
            int currentStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                //0 1 1 5 2 2 6 3 3
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                    if(currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        longestStart = currentStart;
                        //start = i;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }

            for (int i = longestStart; i < longestStart + longestLength; i++)
            {
                Console.WriteLine(string.Join(" ", array));
            }*/

            //1 2 3 4
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentLength = 1;
            int maxLength = 1;
            int currentPosition = 0;
            int maxPosition = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] == array[i - 1])
                {
                    currentLength++;
                    if(maxLength < currentLength)
                    {
                        maxLength = currentLength;
                        maxPosition = currentPosition;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentPosition = i;
                }
            }

            for (int i = maxPosition; i < maxLength + maxPosition; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
