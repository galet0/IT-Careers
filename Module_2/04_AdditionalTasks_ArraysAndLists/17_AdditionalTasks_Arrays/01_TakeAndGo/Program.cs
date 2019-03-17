using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TakeAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            int index = Array.LastIndexOf(nums, number);
            int sum = 0;

            if(index != -1)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }
    }
}
