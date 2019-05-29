using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Methods_Exercises
{
    class Family
    {
        private List<Person> persons;

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
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }

        public void GetPersonsOver30()
        {
            this.persons
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }

        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.persons
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }
    }
}
