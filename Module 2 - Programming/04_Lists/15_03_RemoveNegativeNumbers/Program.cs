using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_03_RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> positive = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > 0)
                {
                    positive.Add(numbers[i]);
                }
                
            }
            if (positive.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positive));
            }
        }
    }
}
