using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02_RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int numberToRemove = numbers[numbers.Count - 1];

            while (numbers.Contains(numberToRemove))
            {
                numbers.Remove(numberToRemove);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
