using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_DefiningClasses_Exercises
{
    class Family
    {
        List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public List<Person> Persons
        {
            get { return this.persons; }
            set { this.persons = value; }
        }

        public void Print()
        {
            this.persons
                .OrderBy(person => person.Name)
                .ToList()
                .ForEach(person => Console.WriteLine(person));
        }

        public void GetPersonsOver30()
        {
            this.persons
                .Where(person => person.Age > 30)
                .OrderBy(person => person.Name)
                .ToList()
                .ForEach(person => Console.WriteLine(person));
        }
        //public Person GetOldest()
        //{
        //    return this.persons.OrderByDescending(person => person.Age).FirstOrDefault();
        //}
    }
}
