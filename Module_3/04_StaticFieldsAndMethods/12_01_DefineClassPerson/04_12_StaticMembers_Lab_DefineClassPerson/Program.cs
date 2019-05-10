using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_12_StaticMembers_Lab_DefineClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Stamat", 25);
            //Console.WriteLine(Person.Count);
            Person person2 = new Person("Hristo", 15);
            //Console.WriteLine(Person.Count);
            Person person3 = new Person("Pepa", 35);
            Console.WriteLine(Person.Count);
        }
    }
}
