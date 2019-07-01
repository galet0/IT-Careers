using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Demo_LosgestOrderEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 3 3 4 4 4 4 5
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int currVal = list[0];
            int currCount = 1;
            int maxCount = 1;
            int maxValue = currVal;

            for (int i = 1; i < list.Count; i++)
            {
                if(currVal == list[i])
                {
                    currCount++;
                    //leftmost
                    if(currCount > maxCount)
                    {
                        maxCount = currCount;
                        maxValue = currVal;
                    }
                    //rightmost
                    //if (currCount >= maxCount)
                    //{
                    //    maxCount = currCount;
                    //    maxValue = currVal;
                    //}
                }
                else
                {
                    currCount = 1;
                    currVal = list[i];
                }
            }

            Console.WriteLine($"{maxValue} -> {maxCount}");
        }
    }
}
