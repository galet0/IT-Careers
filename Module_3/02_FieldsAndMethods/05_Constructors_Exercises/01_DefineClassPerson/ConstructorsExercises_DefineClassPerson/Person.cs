using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorsExercises_DefineClassPerson
{
    class Person
    {
        //fields/полета
        private string name;
        private int age;
        //създаваме си един списък с банкови сметки на човека, защото е възможно той да има повече от една сметка
        private List<BankAccount> accounts = new List<BankAccount>();

        public Person()
        {
            this.name = "No name";
            this.age = 1;
            this.accounts = new List<BankAccount>();
        }

        public Person(int age) : this()
        {
            this.age = age;
        }
        //създаваме си конструктор, който да приема име и години и да създаде обект от тип Person с тези данни
        public Person(string name, int age) : this()
        {
            this.name = name;
            this.age = age;
        }

        //създаваме си конструктор, който да приема име, години и списък с банкови акаунти 
        //и да създаде обект от тип Person с тези данни, като извикваме и предходния конструктор
        public Person(string name, int age, List<BankAccount> bankAccounts) : this(name, age)
        {
            this.accounts = bankAccounts;
        }

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
        
        //метод, който ни връща баланса от всички сметки на човека
        public decimal GetBalance()
        {
            return accounts.Sum(a => a.Balance);
        }
    }
}
