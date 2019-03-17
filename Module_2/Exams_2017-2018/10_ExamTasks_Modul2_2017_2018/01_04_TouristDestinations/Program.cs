using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_TouristDestinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> destinations = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            bool isFound = false;

            while (!input.Equals("End"))
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        string country = command[1];
                        string town = command[2];
                        if (!destinations.ContainsKey(country))
                        {
                            destinations.Add(country, new List<string>());
                        }

                        destinations[country].Add(town);
                        break;
                    case "Remove":
                        string searchedTown = command[1];
                        foreach (var c in destinations)
                        {
                            foreach (var t in c.Value)
                            {
                                if (t.Equals(searchedTown))
                                {
                                    c.Value.Remove(searchedTown);
                                    isFound = true;
                                    break;
                                }
                                else
                                {
                                    isFound = false;
                                }
                            }
                        }
                        break;
                }
                if (isFound == false)
                {
                    Console.WriteLine("City {0} not found", command[1]);
                }

                input = Console.ReadLine();
            }

            var ordered = destinations
                .OrderByDescending(c => c.Value.Count)
                .ThenBy(c => c.Key);

            foreach (var item in ordered)
            {
                //Bulgaria has 3 cities and they are: Sofia, Plovdiv, Varna
                Console.Write("{0} has {1} cities and they are: ", item.Key, item.Value.Count);
                Console.WriteLine(string.Join(", ", item.Value));
            }
        }
    }
}
