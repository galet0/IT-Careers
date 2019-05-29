using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_20_05_19_Modul3_Firms
{
    class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Employee(string id, string firstName, string lastName, int age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = 500.0;
        }

        public Employee(string id, string firstName, string lastName, int age, double salary) : this(id, firstName, lastName, age)
        {
            this.Salary = salary;
        }

        public string Id
        {
            get { return this.id; }
            private set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 2 || value.Length > 8)
                {
                    throw new ArgumentException("Invalid employee name");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid employee name");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid employee age");
                }
                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid salary");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"Employee: {this.FirstName} {this.LastName} with id: {this.Id} and salary: {string.Format("{0:f2}", this.Salary)}";
        }
    }
}
