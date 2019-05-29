using System;

namespace _04_Methods_Exercises
{
    class Program
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
                family.AddMember(person);
            }

            family.Print();
            //for (int i = 0; i < family.Persons.Count; i++)
            //{
            //    Console.WriteLine(family.Persons[i].Name + " " + family.Persons[i].Age);
            //}

            Console.WriteLine("Persons over 30");
            family.GetPersonsOver30();
            Console.WriteLine("Oldest Person");
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine(oldestMember);
        }
    }
}
