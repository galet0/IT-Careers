using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_MaxSequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int startIndex = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;
            //0 1 2 3 4 5 6 7
            //3 4 4 5 5 5 2 2
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] == nums[startIndex])
                {
                    length++;
                }
                else
                {
                    startIndex = i;
                    length = 1;
                }

                if(length > bestLength)
                {
                    bestLength = length;
                    bestStart = startIndex;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
