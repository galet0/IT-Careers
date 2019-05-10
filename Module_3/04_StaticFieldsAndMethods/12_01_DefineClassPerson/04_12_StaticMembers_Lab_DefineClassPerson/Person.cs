using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_12_StaticMembers_Lab_DefineClassPerson
{
    class Person
    {
        private string name;
        private int age;
        private static int count;

        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Person.count += 1;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public static int Count
        {
            get { return Person.count; }
        }

    }
}
