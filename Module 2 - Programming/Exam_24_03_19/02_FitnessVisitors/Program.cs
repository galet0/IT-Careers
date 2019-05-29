using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FitnessVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (!command.Equals("END"))
            {
                switch (command)
                {
                    case "Add visitor":
                        string visitorToAdd = Console.ReadLine();
                        visitors.Add(visitorToAdd);
                        break;
                    case "Add visitor on position":
                        string name = Console.ReadLine();
                        int position = int.Parse(Console.ReadLine());
                        visitors.Insert(position, name);
                        break;
                    case "Remove visitor on position":
                        int removePos = int.Parse(Console.ReadLine());
                        visitors.RemoveAt(removePos);
                        break;
                    case "Remove last visitor":
                        visitors.RemoveAt(visitors.Count - 1);
                        break;
                    case "Remove first visitor":
                        visitors.Remove(visitors[0]);
                        break;  
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
