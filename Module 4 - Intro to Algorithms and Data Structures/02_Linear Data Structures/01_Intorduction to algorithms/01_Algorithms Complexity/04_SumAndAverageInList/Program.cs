using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SumAndAverageInList
{
    class Program
    {
        static void Main(string[] args)
        {
            // N
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            // 3*N = O(N)
            Console.WriteLine("Sum={0}; Average={1}", nums.Sum(), Math.Round(nums.Average()), 2);

            // Total: O(N)
        }
    }
}
