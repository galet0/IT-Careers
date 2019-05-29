using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int initialPower = power;
            int endPower = power;
            string input = "";

            Dictionary<string, int> virusTime = new Dictionary<string, int>();
            bool dead = false;
            do
            {
                input = Console.ReadLine();
                if (dead) { continue; }
                if (input == "end")
                {
                    if (!dead)
                    {
                        Console.WriteLine("Final Health: {0}", endPower);
                    }
                    break;
                }
                else
                {
                    int virusPower;
                    int sumCodes = 0;
                    foreach (char ch in input)
                    {
                        sumCodes += (int)ch;
                    }
                    virusPower = sumCodes / 3;
                    int time;
                    if (virusTime.ContainsKey(input))
                    {
                        time = (int)virusTime[input] / 3;
                    }
                    else
                    {
                        time = (int)virusPower * input.Length;
                        virusTime.Add(input, time);
                    }

                    if (power > time)
                    {
                        Console.WriteLine("Virus {0}:{1} => {2} seconds", input, virusPower, time);
                        Console.WriteLine("{0} defeated in {1}m {2}s", input, time / 60, time % 60);
                        Console.WriteLine("Remaining health: {0}", power - time);

                        if ((power - time) + 0.2 * power > initialPower)
                        {
                            power = initialPower;
                        }
                        else
                        {
                            power += (int)0.2 * power;
                        }
                        endPower = power;
                    }
                    else
                    {
                        Console.WriteLine("Immune System Defeated.");
                        dead = true;
                    }
                }
            } while (input != "end");
        }
    }
}
