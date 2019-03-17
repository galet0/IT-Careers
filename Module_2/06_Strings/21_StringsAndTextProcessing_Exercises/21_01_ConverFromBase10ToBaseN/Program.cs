using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_ConverFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int @base = input[0];
            int number = input[1];
            int rem = 0;
            string output = "";

            while(number > 0)
            {
                rem = number % @base;
                number = number / @base;                
                output += rem;
            }
            output = new string(output.Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
