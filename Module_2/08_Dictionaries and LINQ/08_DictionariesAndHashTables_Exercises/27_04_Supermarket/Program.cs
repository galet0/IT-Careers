using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_04_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> products = 
                new Dictionary<string, Dictionary<double, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("stocked"))
                {
                    break;
                }

                string[] product = input.Split().ToArray();
                string name = product[0];
                double price = double.Parse(product[1]);
                int quantity = int.Parse(product[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Dictionary<double, int>());                    
                }
                
                if (!products[name].ContainsKey(price))
                {
                    products[name].Add(price, 0);
                }
                                
                products[name][price] += quantity;
                
            }

            double total = 0;

            foreach (var item in products)
            {
                string name = item.Key;
                double price = item.Value.Keys.Last();
                int quantity = item.Value.Values.Sum();

                total += price * quantity;
                Console.WriteLine("{0}: ${1} * {2} = ${3:f2}", name, price, quantity, price * quantity);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Grand Total: ${0:f2}", total);
        }
    }
}
