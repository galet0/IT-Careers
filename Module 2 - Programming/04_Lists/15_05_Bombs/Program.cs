using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_05_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //0 1 2 3 4 5 6 7
            //1 2 2 4 2 2 2 9
            //4 2
            //1 2 9 = 12
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            int bombIndex = nums.IndexOf(bomb);

            while (bombIndex != -1)
            {
                int startIndex = bombIndex - power;
                int endIndex = bombIndex + power;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > nums.Count - 1)
                {
                    endIndex = nums.Count - 1;
                }
                int count = endIndex - startIndex + 1;
                nums.RemoveRange(startIndex, count);
                bombIndex = nums.IndexOf(bomb);
            }

            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            //Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(sum);

        }
    }
}
