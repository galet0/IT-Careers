using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_20_05_19_Modul3_Firms
{
    class Company
    {
        private string name;
        private List<Employee> employees;
        private string city;

        public Company(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.Employees = new List<Employee>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 2 || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid company name");
                }
                this.name = value;
            }
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            private set
            {
                this.employees = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set
            {
                if ((value.Length < 4 && !Char.IsUpper(value[0]))
                    || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid city");
                }
                this.city = value;
            }
        }

        public void HireEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void FireEmployee(string employeeId)
        {
            for (int i = 0; i < this.Employees.Count; i++)
            {
                if (this.employees[i].Id.Equals(employeeId))
                {
                    this.employees.Remove(this.employees[i]);
                }
            }
        }

        public void IncreaseSalaries(double amount)
        {
            this.Employees.ForEach(e => e.Salary += amount);
        }

        public void DecreaseSalaries(double amount)
        {
            for (int i = 0; i < this.Employees.Count; i++)
            {
                if (this.Employees[i].Salary - amount > 0)
                {
                    this.Employees[i].Salary -= amount;
                }
            }
        }

        public Employee GetMostHighPaidEmployee()
        {
            return this.Employees
                .OrderByDescending(e => e.Salary)
                .ToList()
                .FirstOrDefault();
        }

        public List<Employee> GetTopThreeMostHighPaidEmployees()
        {
            return this.Employees
                .OrderByDescending(e => e.Salary)
                .Take(3)
                .ToList();
        }

        public bool CheckEmployeeIsPresent(string employeeId)
        {
            bool result = false;
            foreach (Employee employee in this.Employees)
            {
                if (employee.Id.Equals(employeeId))
                {
                    result = true;
                }
            }
            return result;
        }

        public double GetAverageEmployeeSalary()
        {
            return this.Employees.Average(e => e.Salary);
        }

        public override string ToString()
        {
            //Company itguruOOD from Sofia has the following employees:
            //--> Employee: Gosho Goshov with id: goshoId and salary: 725.00
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Company " + this.Name
                + " from " + this.City + " has the following employees:{0}", Environment.NewLine);

            foreach (Employee employee in employees)
            {
                result.AppendFormat("--> {0}{1}", employee, Environment.NewLine);
            }
            return result.ToString();
        }
    }
}
