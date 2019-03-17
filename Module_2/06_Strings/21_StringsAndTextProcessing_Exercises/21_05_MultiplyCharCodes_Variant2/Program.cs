using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_05_MultiplyCharCodes_Variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string first = words[0];
            string second = words[1];
            int length = Math.Max(first.Length, second.Length);
            double result = 0.0;

            if(first.Length < second.Length)
            {
                first = first.PadRight(length, '\x0001');
            }
            else if(first.Length > second.Length)
            {
                second = second.PadRight(length, '\x0001');
            }

            for (int i = 0; i < length; i++)
            {
                result += first[i] * second[i];
            }
            Console.WriteLine(result);
        }
    }
}
