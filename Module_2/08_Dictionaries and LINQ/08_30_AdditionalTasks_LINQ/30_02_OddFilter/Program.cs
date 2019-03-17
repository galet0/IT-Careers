using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_02_OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .ToArray();

           
            double avg = nums.Average();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]> avg)
                {
                    nums[i]++;
                }
                else
                {
                    nums[i]--;
                }
            }
            Console.WriteLine();
        }
    }
}
