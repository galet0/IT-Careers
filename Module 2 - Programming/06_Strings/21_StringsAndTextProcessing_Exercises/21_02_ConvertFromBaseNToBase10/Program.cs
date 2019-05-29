using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int @base = int.Parse(input[0]);
            char[] number = input[1].Reverse().ToArray();//13
            double sum = 0;

            for (int i = 0; i < number.Length; i++)
            {//31
                sum += int.Parse(number[i].ToString()) * Math.Pow(@base, i);
            }
            
            Console.WriteLine(sum);
        }
    }
}
