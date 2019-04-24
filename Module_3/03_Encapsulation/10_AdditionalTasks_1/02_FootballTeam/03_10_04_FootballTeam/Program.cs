using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_10_04_FootballTeam
{
    class Program
    {
        private static Dictionary<string, Team> teams = new Dictionary<string, Team>();
        private static Dictionary<string, Player> players = new Dictionary<string, Player>();
        static void Main(string[] args)
        {
            //Футболен отбор има променлив брой играчи, име и рейтинг
            string command;


            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(';');
                switch (commandArgs[0])
                {
                    case "Team":
                        string name = commandArgs[1];
                        CreateTeam(name);
                        break;
                    case "Add":
                        string teamName = commandArgs[1];
                        string playerName = commandArgs[2];
                        Player player= CreatePlayer(playerName, commandArgs.Skip(3).ToArray());
                        if(player != null)
                        {
                            AddPlayer(teamName, players[playerName]);
                        }
                        break;
                    case "Remove":
                        string teamNameFromRemove = commandArgs[1];
                        string playerNameToRemove = commandArgs[2];
                        RemovePlayerFromTeam(teamNameFromRemove, playerNameToRemove);
                        break;
                    case "Rating":
                        string teamNameRating = commandArgs[1];
                        PrintTeamRating(teamNameRating);
                        break;
                }
            }
        }

        private static void PrintTeamRating(string teamNameRating)
        {
            if (teams.ContainsKey(teamNameRating))
            {
                Console.WriteLine("{0} - {1}", teamNameRating, teams[teamNameRating].GetRating());
            }
            else
            {
                Console.WriteLine("Team {0} does not exists.", teamNameRating);
            }
        }

        private static void RemovePlayerFromTeam(string teamNameFromRemove, string playerNameToRemove)
        {
            try
            {
                teams[teamNameFromRemove].RemovePlayer(playerNameToRemove);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static Player CreatePlayer(string playerName, string[] stats)
        {
            Player player = null;
            try
            {
                int endurance = int.Parse(stats[0]);
                int sprint = int.Parse(stats[1]);
                int dribble = int.Parse(stats[2]);
                int passing = int.Parse(stats[3]);
                int shooting = int.Parse(stats[4]);
                player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                players.Add(playerName, player);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return player;
        }

        private static void AddPlayer(string teamName, Player player)
        {
            if (teams.ContainsKey(teamName))
            {
                teams[teamName].AddPlayer(player);
            }
            else
            {
                Console.WriteLine("Team {0}  does not exists.", teamName);
            }

        }

        private static void CreateTeam(string name)
        {
            try
            {
                Team team = new Team(name);
                teams.Add(name, team);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
