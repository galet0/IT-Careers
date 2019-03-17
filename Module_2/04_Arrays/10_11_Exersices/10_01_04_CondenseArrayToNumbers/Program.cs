using System;
using System.Linq;

namespace _10_01_04_CondenseArrayToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            //1 2 3
            //3 5
            //8
            while(numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currNum = numbers[i];
                    int nextNum = numbers[i + 1];
                    condensed[i] = currNum + nextNum;
                }

                numbers = condensed;
            }
            //Console.WriteLine(numbers.Length);
            Console.WriteLine(string.Join("", numbers));
        }
    }
}
