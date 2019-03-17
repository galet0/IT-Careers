using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                .Split()
                .ToList();
            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                //123 234 12
                char[] numArr = nums[i].ToCharArray();//[1][2][3]
                Array.Reverse(numArr);//[3][2][1]
                sum += int.Parse(new string(numArr));// int.Parse("321") -> 321
            }

            Console.WriteLine(sum);
        }
    }
}
