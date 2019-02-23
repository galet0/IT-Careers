using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_06_Store_UpdatedVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split()
                .ToArray();
            long[] quantities = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            decimal[] prices = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "done")
            {
                string[] orderArr = input.Split().ToArray();
                int index = Array.IndexOf(products, orderArr[0]);
                long orderQuantity = long.Parse(orderArr[1]);
                long inStock = 0;
                if (index < quantities.Length)
                {
                    inStock = quantities[index];
                }
                else
                {
                    inStock = 0;
                }
                if (inStock >= orderQuantity)
                {
                    quantities[index] -= orderQuantity;
                    decimal totalPrice = prices[index] * orderQuantity;
                    Console.WriteLine("{0} x {1} costs {2:f2}", 
                        products[index], orderQuantity, totalPrice);
                }
                else
                {
                    Console.WriteLine("We do not have enough {0}", products[index]);
                }
                input = Console.ReadLine();
            };
        }
    }
}
