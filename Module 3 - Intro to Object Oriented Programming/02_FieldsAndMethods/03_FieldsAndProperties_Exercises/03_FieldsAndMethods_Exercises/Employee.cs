﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FieldsAndMethods_Exercises
{
    class Employee
    {
        //Дефинирайте клас Employee, съдържащ информация за 
        //име, заплата, длъжност, отдел, ел.поща и възраст. 
        //Полетата име, заплата, длъжност и отдел са задължителни, останалите са опционални. 
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
