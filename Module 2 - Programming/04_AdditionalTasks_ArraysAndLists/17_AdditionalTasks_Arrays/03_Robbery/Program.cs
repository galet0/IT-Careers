using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Robbery
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 20
            int[] prices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int jewerly = prices[0];//10
            int gold = prices[1];//20
            int profit = 0;
            int totalExpenses = 0;

            string line = Console.ReadLine();
            while (!line.Equals("Jail Time"))
            {
                //% - jewerly, $ - gold
                //плячка - разход за обира
                //ASDA% 50
                string[] robbery = line.Split();
                string loot = robbery[0];//ASDA% 
                int expenses = int.Parse(robbery[1]);//50

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i].Equals('%'))
                    {
                        profit += jewerly;
                    }
                    else if (loot[i].Equals('$'))
                    {
                        profit += gold;
                    }

                }

                totalExpenses += expenses;
                line = Console.ReadLine();
            }
            
            if(profit >= totalExpenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", profit - totalExpenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses - profit);
            }

        }
    }
}
