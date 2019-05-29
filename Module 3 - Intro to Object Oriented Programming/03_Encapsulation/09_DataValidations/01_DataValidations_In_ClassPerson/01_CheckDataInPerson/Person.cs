using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CheckDataInPerson
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
            set
            {
                if(value.Length < 3 
                    || string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value))
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
                if (value.Length < 3
                    || string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                this.lastName = value;
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

        public double Salary
        {
            get { return this.salary; }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(double percent)
        {
            if (this.Age > 30)
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
            return $"{this.firstName} {this.lastName} get {string.Format("{0:f2}", this.Salary)} leva";
        }
    }
}
