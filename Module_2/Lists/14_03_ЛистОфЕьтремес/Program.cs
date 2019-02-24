using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_03_ListOfExtremes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            //0 1 2 3 4 5 6 7
            //5 4 8 5 7 8 2 1
            int min = nums[0];
            int max = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
            }

            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] == min || nums[i] == max)
                {
                    result.Add(nums[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
