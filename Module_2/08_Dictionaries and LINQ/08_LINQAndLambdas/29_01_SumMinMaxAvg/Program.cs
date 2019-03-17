using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_01_SumMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int sum = numbers.Sum();
            int min = numbers.Min();
            int max = numbers.Max();
            double avg = numbers.Average();
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Average = {0}", avg);
        }
    }
}
