using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_05_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split().ToArray();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string productName = "";
            do
            {
                productName = Console.ReadLine();
                //int index = Array.IndexOf(products, productName);
                //Console.WriteLine("{0} costs: {1:f2}; Available quantity: {2}",
                //                        products[index], prices[index], quantities[index]);
                for (int i = 0; i < products.Length; i++)
                {
                    if (productName == products[i])
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}",
                                        products[i], prices[i], quantities[i]);
                        break;
                    }
                }
            }
            while (productName != "done");
        }
    }
}
