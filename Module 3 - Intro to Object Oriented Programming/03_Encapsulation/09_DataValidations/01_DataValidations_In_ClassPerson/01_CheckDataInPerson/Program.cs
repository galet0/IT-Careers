using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CheckDataInPerson
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

                //създаваме try - catch блок с който ще прихванем изключението(exception)
                //ако потребителя е въвел невалидни данни
                // в catch отпечатваме съобщението за грешка, 
                //което сме написали при валидациите на данните в сетъра на клас Person
                try
                {
                    Person person = new Person(firstName, lastName, age, salary);
                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);              
                }
                
            }
            double bonus = double.Parse(Console.ReadLine());
            foreach (Person person in persons)
            {
                person.IncreaseSalary(bonus);
            }

            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    
    }
}
