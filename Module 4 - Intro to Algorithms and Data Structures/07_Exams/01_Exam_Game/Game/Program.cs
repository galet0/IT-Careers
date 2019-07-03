using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<String, CapacityList> players = new Dictionary<string, CapacityList>();

            string command = "";
            do
            {
                command = Console.ReadLine();
                string[] commands = command.Split(' ').ToArray();
                switch (commands[0])
                {
                    case "Dice":
                        string player = commands[1];
                        int value1 = int.Parse(commands[2]);
                        int value2 = int.Parse(commands[3]);
                        if (players.ContainsKey(player))
                        {
                            players[player].Add(new Pair(value1, value2));
                        }
                        else
                        {
                            players.Add(player, new CapacityList(capacity));
                            players[player].Add(new Pair(value1, value2));
                        }
                        break;
                    case "CurrentPairSum":
                        /* CurrentPairSum <играч> - тази команда показва сумата 
                         * от всички двойки във формат: (a, b), 
                         * където a и b са съответно първия и 
                         * втория елемент на получената двойка.*/
                        string playerName = commands[1];
                        if (players.ContainsKey(playerName))
                        {
                            Console.WriteLine(players[playerName].Sum());
                        }
                        break;
                    case "CurrentStanding":
                        /*CurrentStanding - тази команда отпечатва 
                         * класиране в намалящ ред, в което на 
                         * всеки ред има информация за един 
                         * играч във формат: “{играч} - (a, b)”. 
                         * Където a и b са числата от двойката на 
                         * съответния играч, с която той участва в класирането.*/
                        players = players.OrderBy(element => element.Value.Sum().Difference())
                            .ToDictionary(element => element.Key, element => element.Value);
                        foreach (var item in players)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value.Sum());
                        }
                        break;
                    case "CurrentState":
                        /* CurrentState <играч> - тази команда 
                         * отпечатва всички двойки, които са съхранени 
                         * в колекцията на дадения играч, 
                         * без значение как са получени*/
                        string playerNameState = commands[1];
                        if (players.ContainsKey(playerNameState))
                        {
                            players[playerNameState].PrintCurrentState();
                        }

                        break;
                    case "Winner":
                        /*Winner - тази команда отпечатва 
                         * победителя във формат: “{играч} wins the game!”. 
                         * Командата ще бъде викана само тогава, 
                         * когато може да се определи еднозначно победител.*/
                        players = players.OrderBy(element => element.Value.Sum().Difference())
                            .ThenBy(element => element.Key)
                            .ToDictionary(element => element.Key, element => element.Value);
                        Console.WriteLine("{0} wins the game!", players.First().Key);
                        break;

                }
            } while (command != "End");
        }
    }
}
