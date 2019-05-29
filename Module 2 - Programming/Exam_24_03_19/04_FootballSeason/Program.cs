using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FootballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();

            string input = Console.ReadLine();

            while(!input.Equals("End of season"))
            {
                string[] line = input.Split(" -".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int countGoals = int.Parse(line[1]);

                if (!players.ContainsKey(name))
                {
                    players.Add(name, 0);
                }

                players[name] += countGoals;
                input = Console.ReadLine();
            }

            foreach (var player in players)
            {
                Console.WriteLine("{0} -> {1}", player.Key, player.Value);
            }
        }
    }
}
