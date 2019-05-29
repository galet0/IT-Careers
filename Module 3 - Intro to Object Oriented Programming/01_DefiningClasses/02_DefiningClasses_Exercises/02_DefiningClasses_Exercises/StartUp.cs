using System;
using System.Linq;

namespace _02_DefiningClasses_Exercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.Persons.Add(person);
            }

            family.Print();
            //Console.WriteLine("Oldest:");
            //Console.WriteLine(family.GetOldest().ToString());
            Console.WriteLine("Statistic:");
            family.GetPersonsOver30();
        }
    }
}
