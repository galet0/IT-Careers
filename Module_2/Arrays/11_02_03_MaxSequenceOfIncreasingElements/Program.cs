using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_03_MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentLength = 1;
            int maxLength = 1;
            int currentPosition = 0;
            int maxPosition = 0;

            for (int i = 1; i < array.Length; i++)
            {
                //0 1 1 2 2 3 3
                if (array[i] > array[i - 1])
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
