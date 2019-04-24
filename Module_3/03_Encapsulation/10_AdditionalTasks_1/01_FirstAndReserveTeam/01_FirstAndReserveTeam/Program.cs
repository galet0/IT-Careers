using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_FirstAndReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                double salary = double.Parse(input[3]);

                try
                {
                    Person person = new Person(firstName, lastName, salary, age);
                    persons.Add(person);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

            }

            Team team = new Team("team");
            for (int i = 0; i < persons.Count; i++)
            {
                team.AddPlayer(persons[i]);
            }
            Console.WriteLine("First team have {0} players", team.FirstTeam.Count);
            Console.WriteLine("Reserve team have {0} players", team.ReserveTeam.Count);
        }
    }
}
