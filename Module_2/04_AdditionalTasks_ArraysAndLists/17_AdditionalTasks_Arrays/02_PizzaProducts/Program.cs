using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PizzaProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            int length = int.Parse(Console.ReadLine());
            int countIngredients = 0;
            string[] ingrediants = new string[10];
            int index = 0;

            for (int i = 0; i < products.Length; i++)
            {
                if(products[i].Length == length)
                {
                    countIngredients++;
                    ingrediants[index] = products[i];
                    index++;
                    Console.WriteLine("Adding {0}", products[i]);
                }
                if(i >= 10)
                {
                    break;
                }
            }
            
            Console.WriteLine("Made pizza with total of {0} ingredients.", countIngredients);
            Console.Write("The ingredients are: ");
            string result = "";
            for (int i = 0; i < countIngredients; i++)
            {
                result += ingrediants[i] + ", ";
            }
            Console.WriteLine(result.Substring(0, result.Length-2));
        }
    }
}
