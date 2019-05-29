using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_01_OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Select(s => s.ToLower())
                .ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if(words.ContainsKey(word) == false)
                {
                    words.Add(word, 0);
                }

                words[word]++;
            }

            List<string> oddOccurences = new List<string>();
            foreach(var pair in words)
            {
                if(pair.Value % 2 != 0)
                {
                    oddOccurences.Add(pair.Key);
                }
                
            }
            Console.WriteLine(string.Join(", ", oddOccurences));
        }
    }
}
