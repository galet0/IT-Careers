using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_04_UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            foreach (char symbol  in input)
            {
                result += GetEscapeSequence(symbol);
            }

            Console.WriteLine(result);

        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X2");
        }
    }
}
