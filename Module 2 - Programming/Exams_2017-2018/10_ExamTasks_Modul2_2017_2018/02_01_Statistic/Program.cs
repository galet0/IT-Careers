using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01_Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int agentsCount = int.Parse(Console.ReadLine());
            decimal totalDealsPrice = 0.0m;
            decimal sumDeals = 0m;

            for (int agent = 0; agent < agentsCount; agent++)
            {
                int dealsCount = int.Parse(Console.ReadLine());

                for (int deal = 0; deal < dealsCount; deal++)
                {
                    int quadrature = int.Parse(Console.ReadLine());
                    decimal price = decimal.Parse(Console.ReadLine());

                    sumDeals += quadrature * price;
                }
            }

            totalDealsPrice += sumDeals;
            decimal avg = totalDealsPrice / agentsCount;
            Console.WriteLine("{0:f3}", avg);
        }
    }
}
