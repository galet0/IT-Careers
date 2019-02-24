using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04_MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();
            List<int> results = new List<int>();

            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                string[] splitted = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < splitted.Length; j++)
                {
                    results.Add(int.Parse(splitted[j]));
                }
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
