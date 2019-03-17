using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_CryptoInvestments_Variant2
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
            decimal totalCommision = 0m;

            Dictionary<string, decimal> cryptoWallet = new Dictionary<string, decimal>();

            for (int i = 0; i < transactions; i++)
            {
                int actives = int.Parse(Console.ReadLine());
                string currency = Console.ReadLine();
                string buyOrSell = Console.ReadLine();

                decimal sum = 0m;

                switch (currency)
                {
                    case "Bitcoin":
                        sum = actives * btcPrice;
                        break;
                    case "Ethereum":
                        sum = actives * ethereumPrice;
                        break;
                    case "Litecoin":
                        sum = actives * litecoinPrice;
                        break;
                }

                totalCommision += sum * commissionPrice;

                if (!cryptoWallet.ContainsKey(currency))
                {
                    cryptoWallet.Add(currency, 0);
                }

                if (buyOrSell.Equals("Buy"))
                {
                    cryptoWallet[currency] += sum;
                }
                else if (buyOrSell.Equals("Sell"))
                {
                    cryptoWallet[currency] -= sum;
                }
            }

            decimal profit = 0.0m;
            foreach (var crypto in cryptoWallet)
            {
                profit += crypto.Value;
            }

            Console.WriteLine("{0:f16}", profit - totalCommision);
        }
    }
}
