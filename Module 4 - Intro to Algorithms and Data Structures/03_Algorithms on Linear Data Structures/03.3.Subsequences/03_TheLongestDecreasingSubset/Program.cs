using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_TheLongestDecreasingSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int currValue = list[0];
            int maxValue = currValue;

            int currCount = 1;
            int maxCount = 1;
            int counter = 1;
            //1 2 3 4 2 3 6 7
            //1 2 3 4 10 6 7 8 9 10
            for (int i = 1; i < list.Count; i++)
            {
                if (currValue - counter == list[i])
                {
                    currCount++;
                    counter++;
                    if (currCount > maxCount)
                    {
                        maxCount = currCount;
                        maxValue = currValue;
                    }

                }
                else
                {
                    currCount = 1;
                    currValue = list[i];
                    counter = 1;
                }

            }
            Console.WriteLine();
            Console.WriteLine(maxCount);
        }
    }
}
