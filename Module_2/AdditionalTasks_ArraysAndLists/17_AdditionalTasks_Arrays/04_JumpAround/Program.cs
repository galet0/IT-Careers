using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)          //0  1   2  3   4
                .ToArray();     //new int[] { 3, 7, 12, 2, 10 };
            int startIndex = 0;
            int sum = 0;

            while (true)
            {
                //0 1  2 3  4
                //3 7 12 2 10
                sum += nums[startIndex];
                int nextIndex = startIndex + nums[startIndex];

                if(nextIndex < nums.Length)
                {
                    startIndex = nextIndex;
                    continue;
                }

                nextIndex = startIndex - nums[startIndex];
                if(nextIndex >= 0)
                {
                    startIndex = nextIndex;
                    continue;
                }

                break;
            }

            Console.WriteLine(sum);
        }
    }
}
