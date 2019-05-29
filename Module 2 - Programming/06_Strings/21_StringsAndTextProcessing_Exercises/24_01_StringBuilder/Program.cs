using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_01_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            switch (commands[0])
            {
                case "Append":
                    text = text.Append(commands[1]);
                    break;
                case "Remove":
                    text = text.Remove(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "Insert":
                    text = text.Insert(int.Parse(commands[1]), commands[2]);
                    break;
                case "Replace":
                    text = text.Replace(commands[1], commands[2]);
                    break;
            }

            Console.WriteLine(text);
        }
    }
}
