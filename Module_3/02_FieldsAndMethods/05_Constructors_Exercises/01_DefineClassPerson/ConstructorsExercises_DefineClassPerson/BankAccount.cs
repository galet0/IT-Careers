using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsExercises_DefineClassPerson
{
    class BankAccount
    {
        //fields/полета на класа
        private int id;
        private decimal balance;
        //private List<string> list;

        //празен конструктор
        public BankAccount()
        {
            //когато имаме някаква колекция, дали ще е масив, списък, речник
            //винаги трябва да се инициализира в конструктора(но не е задължително да е в празни конструктор, може и в някой от другите, където ни трябва)
            //this.list = new List<string>();
        }

        //конструктор, който приема id на банковата сметка, за да поставим стойност на id-то директно при създаването на обекта
        public BankAccount(int id) : this()
        {
            this.id = id;
        }
        //конструктор, който приема id и balance на банковата сметка, за да поставим стойност на id-то И balance директно при създаването на обекта
        public BankAccount(int id, decimal balance) : this()
        {
            this.id = id;
            this.balance = balance;
        }

        //properties/свойства-те са ни нужни, за достъп до полетата на класа(и за валидации)
        public int Id
        {
            //get - връща ни стойността на полето, което искаме
            get { return this.id; }
            //set - сетва(задава) стойност на полето
            set { this.id = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //метод, който осъществява увеличаване на баланса при депозит
        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        //метод за теглене на пари от сметката
        public void Withdraw(decimal amount)
        {
            //проверява дали в сметката има достатъчно баланс
            if (this.balance >= amount)
            {
                this.balance -= amount;
            }
            else
            {
                //Ако се опитате да изтеглите сума, която е по-голяма от баланса, изведете "Insufficient balance".
                Console.WriteLine("Insufficient balance");
            }

        }

        //пренаписваме метода ToString(), за да може когато кажем на обекта от клас BankAccount (account.ToString())
        //да отпечата това, което искаме ние, не името на класа и namespace в който се намира
        public override string ToString()
        {
            return "Account ID" + this.id +
                ", balance " + string.Format("{0:0.00}", this.balance);
            //една опция за форматиране на резултата с до два знака след запетаята
            //string.Format("{0:0.00}", this.balance)

        }
    }
}
