using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                   .Split(" ,;:.!()\"'\\/[]".ToCharArray(),
                   StringSplitOptions.RemoveEmptyEntries);
            List<string> mixed = new List<string>();
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                if (isLower(current))
                {
                    lower.Add(current);
                }
                else if (isUpper(current))
                {
                    upper.Add(current);
                }
                else
                {
                    mixed.Add(current);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lower));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upper));
        }

        static bool isUpper(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        static bool isLower(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
