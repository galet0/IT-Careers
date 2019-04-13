using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_FieldsAndMethods_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                //Pesho 120.00 Dev Development pesho@abv.bg 28
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                Employee employee = new Employee(name, salary, position, department);

                if (input.Length == 5)
                {
                    if (int.TryParse(input[4], out int result))
                    {
                        int age = int.Parse(input[4]);
                        employee.Age = age;
                    }
                    else
                    {
                        string email = input[4];
                        employee.Email = email;
                    }
                }
                else if (input.Length == 6)
                {
                    string email = input[4];
                    int age = int.Parse(input[5]);
                    employee.Age = age;
                    employee.Email = email;
                }

                employees.Add(employee);
            }
            /*
            //Pesho 120.00 Dev Development pesho@abv.bg 28
            //Toncho 333.33 Manager Marketing 33
            //Ivan 840.20 ProjectLeader Development ivan @ivan.com
            //Gosho 0.20 Freeloader Nowhere 18

            //от колекцията от всички служители 
            var topDepartment = employees
                .GroupBy(e => e.Department) //групираме ги по Department
                .ToDictionary(x => x.Key, y => y.Select(s => s)) //за да можем да изведем тези данни 
                                                                 //е добре да ползваме речник, на който 
                                                                 //ключа ще бъде Department, а със y => y.Select(s => s)
                                                                 //казваме да вземе за Value на речника цялата колекция employees
                .OrderByDescending(x => x.Value.Average(s => s.Salary)) //сортираме ги по средната стойност на заплатата, но ги сортирам в 
                                                            //низходящ ред, за да можем да вземем най-високата средна заплата
                                                            //x.Value - колекцията от всички employees, на всеки служител
                                                            //му вземаме заплатата и пресмятаме средната стойност
                .FirstOrDefault();

            Console.WriteLine("Highest Average Salary: {0}", topDepartment.Key);

            foreach (Employee employee in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine("{0} {1} {2} {3}", employee.Name, employee.Salary, employee.Email, employee.Age);
            }
            */
            Dictionary<string, decimal> totalSalaries = new Dictionary<string, decimal>();
            foreach (Employee employee in employees)
            {
                if (totalSalaries.ContainsKey(employee.Department))
                {
                    totalSalaries[employee.Department] += employee.Salary;
                }
                else
                {
                    totalSalaries[employee.Department] = employee.Salary;
                }
            }

            decimal highestAverageSalary = decimal.MinValue;
            string highestPaidDepartment = "";

            foreach (string department in totalSalaries.Keys)
            {
                decimal averageSalary = totalSalaries[department] / employees.Where(e => e.Department == department).Count();
                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    highestPaidDepartment = department;
                }
            }

            Console.WriteLine("Highest Average Salary: {0}", highestPaidDepartment);
            foreach (Employee employee in employees.Where(e => e.Department == highestPaidDepartment).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine("{0} {1:F2} {2} {3}", employee.Name, employee.Salary, employee.Email, employee.Age);
            }
        }
    }
}
