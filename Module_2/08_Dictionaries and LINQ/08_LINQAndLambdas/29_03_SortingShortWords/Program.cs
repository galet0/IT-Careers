using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_03_SortingShortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            text = text
                .OrderBy(c => c)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
