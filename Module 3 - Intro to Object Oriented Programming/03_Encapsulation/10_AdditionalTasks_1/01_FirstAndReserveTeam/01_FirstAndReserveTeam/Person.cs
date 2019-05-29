using System;
using System.Collections.Generic;
using System.Text;

namespace _01_FirstAndReserveTeam
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person()
        {

        }

        public Person(string firstName, string lastName, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public Person(string firstName, string lastName, double salary, int age)
            : this(firstName, lastName, salary)
        {
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                this.lastName = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " +
                this.lastName + " get " +
                string.Format("{0:f2}", this.salary) + " leva";
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.Salary += this.Salary * percent / 100;
            }
            else
            {
                this.Salary += this.Salary * percent / 200;
            }
        }
    }
}
