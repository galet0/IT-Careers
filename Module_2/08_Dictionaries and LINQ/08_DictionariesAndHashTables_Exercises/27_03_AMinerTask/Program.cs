using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_03_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());                
                if (!miner.ContainsKey(resource))
                {
                    miner.Add(resource, 0);
                }

                miner[resource] += quantity;
            }

            foreach (var pair in miner)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
