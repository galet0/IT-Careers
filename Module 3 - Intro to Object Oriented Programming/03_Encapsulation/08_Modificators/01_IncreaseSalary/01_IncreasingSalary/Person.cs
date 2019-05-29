using System;
using System.Collections.Generic;
using System.Text;

namespace _01_IncreasingSalary
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(string firstName, string lastName, int age, double salary) 
            : this(firstName, lastName, age)
        {
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public double Salary { get; private set; }

        public void IncreaseSalary(double percent)
        {
            if(this.Age > 30)
            {
                this.Salary += this.Salary * percent / 100;
            }
            else
            {
                this.Salary += this.Salary * percent / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {string.Format("{0:f2}",this.Salary)} leva";
        }
    }
}
