using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_CryptoInvestments
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal btcPrice = decimal.Parse(Console.ReadLine());
            decimal ethereumPrice = decimal.Parse(Console.ReadLine());
            decimal litecoinPrice = decimal.Parse(Console.ReadLine());
            int transactions = int.Parse(Console.ReadLine());
            decimal commissionPrice = 0.073456764216789345m;
            decimal totalSum = 0.0m;
            decimal totalCommission = 0.0m;
            decimal profit = 0.0m;

            for (int i = 0; i < transactions; i++)
            {
                int actives = int.Parse(Console.ReadLine());
                string currency = Console.ReadLine();
                string buyOrSell = Console.ReadLine();
                decimal sum = 0.0m;
                //1000 * Bitcoin = 9846300,
                //комисионна = 9846300 * 0.073456764216789345 = 723277.3375077729276735, 

                //2000 * Litecoin = 471200,
                //комисионна = 471200 * 0.073456764216789345 = 34612.827298951139364

                //сумата на всички комисионни: 757890.1648067240670375
                //9846300 + 471200 - 757890.1648067240670375 = 9559609.8351932759329625

                if (currency.Equals("Bitcoin"))
                {
                    sum = actives * btcPrice;
                }
                else if(currency.Equals("Ethereum"))
                {
                    sum = actives * ethereumPrice;
                }
                else if (currency.Equals("Litecoin"))
                {
                    sum = actives * litecoinPrice;
                }
                if (buyOrSell.Equals("Buy"))
                {
                    totalSum += sum;
                }
                else if (buyOrSell.Equals("Sell"))
                {
                    totalSum -= sum;
                }

                totalCommission += sum * commissionPrice;
            }
            profit = totalSum - totalCommission;
            Console.WriteLine("{0:f16}", profit);
        }
    }
}
