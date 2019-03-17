using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_01_SortHours
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .OrderBy(h => h)
                .ToList();
            Console.WriteLine(string.Join(", ", input));

        }
    }
}
