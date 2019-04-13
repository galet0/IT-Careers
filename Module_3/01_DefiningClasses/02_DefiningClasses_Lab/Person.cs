using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_04_19_ItKarieri_DefiningClasses
{
    class Person
    {
        //fields/полета
        private string name;
        private int age;
        //създаваме си един списък с банкови сметки на човека, защото е възможно той да има повече от една сметка
        private List<BankAccount> accounts = new List<BankAccount>();

        //тук в случая нямаме конструктор, но когато си създаваме обекта Person person = new Person();
        //се извиква дефолтния конструктор, който е празен конструктор

        //properties/свойства
        public string Name
        {
            //get - връща ни стойността на полето, което искаме
            get { return name; }
            //set - сетва(задава) стойност на полето
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
         
        //метод, който ни отпечатва информацията за обекта person 
        public void IntorduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0}" +
                " и съм на {1} години.", name, age);
        }

        //метод, който ни връща баланса от всички сметки на човека
        public decimal GetBalance()
        {
            return accounts.Sum(a => a.Balance);
        }
    }
}
