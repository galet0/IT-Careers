using System;
using System.Collections.Generic;
using System.Text;

namespace _13_04_19_ItKarieri_DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //създаваме си обект/нова инстанция от класа BankAccount, 
            //като използваме конструктора, който директно запазва стойностите за Id И баланса по сметката
            BankAccount account = new BankAccount(1, 0);
            //правим депозит по сметката, като използваме метода Deposit в класа BankAccount
            account.Deposit(15);
            //правим теглене от сметката, като използваме метода Withdraw в класа BankAccount
            account.Withdraw(5);

            //четем си входа
            string input = Console.ReadLine();

            //създаваме си един речник, който че ни държи всички банкови сметки
            //като за ключ му подаваме id на банковата сметка, а за стойност(value) слагаме обекта account, който сме създали с new BankAccount()
            Dictionary<int, BankAccount> accounts = 
                new Dictionary<int, BankAccount>();

            //добавяме Id И обекта account в този речник
            accounts.Add(account.Id, account);

            while (!input.Equals("End"))
            {
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "Create":
                        int id = int.Parse(commands[1]);
                        //метод за създаване на клиент 
                        Create(id, accounts);
                        break;
                    case "Deposit":
                        int idDep = int.Parse(commands[1]);
                        decimal amount = decimal.Parse(commands[2]);
                        //метод за депозиране в сметката
                        Deposit(idDep, amount, accounts);
                        break;
                    case "Withdraw":
                        int idWith = int.Parse(commands[1]);
                        decimal amountWith = decimal.Parse(commands[2]);
                        //метод за теглене от сметката
                        Withdraw(idWith, amountWith, accounts);
                        break;
                    case "Print":
                        int idPrint = int.Parse(commands[1]);
                        //метод за извеждане на информацията за акаунта
                        Print(idPrint, accounts);
                        break;
                }

                input = Console.ReadLine();
            }

        }

        private static void Print(int idPrint, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(idPrint))
            {
                //използваме override метода ToString() от класа BankAccount
                Console.WriteLine(accounts[idPrint].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(int idWith, decimal amountWith, Dictionary<int, BankAccount> accounts)
        {
            //отново проверяваме дали съществува такова Id в нашия речник, за да сме сигурни, 
            //че ако подадем невалидно Id нашата програма няма да изгърми
            if (accounts.ContainsKey(idWith))
            {
                //изпълняваме метода за теглене от сметката, който сме създали в класа BankAccount
                accounts[idWith].Withdraw(amountWith);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(int idDep, decimal amount, 
            Dictionary<int, BankAccount> accounts)
        {
            //отново проверяваме дали съществува такова Id в нашия речник, за да сме сигурни, 
            //че ако подадем невалидно Id нашата програма няма да изгърми
            //Ако се опитате да извършите операция върху несъществуваща сметка, изведете "Account does not exist".
            if (accounts.ContainsKey(idDep))
            {
                //конткретния account
                //изпълняваме метода за депозиране в сметката, който сме създали в класа BankAccount
                accounts[idDep].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        
        private static void Create(int id, Dictionary<int, BankAccount> accounts)
        {
            //Проверяваме дали речника ни съдържа това Id
            //Ако се опитате да създадете сметка със съществуващо Id, изведете "Account already exists".
            if (!accounts.ContainsKey(id))
            {
                //създаваме си нов обект account
                BankAccount account = new BankAccount(id);
                //и го добавяме в речника
                accounts.Add(id, account);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
