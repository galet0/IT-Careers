using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_ImmuneSystem_Variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            int immuneSystem = int.Parse(Console.ReadLine());
            int currentHealth = immuneSystem;
            int finalHealth = 0;
            Dictionary<string, int> viruses = new Dictionary<string, int>();

            while (true)
            {
                string virus = Console.ReadLine();
                int virusPower = 0;
                int time = 0;

                if (virus.Equals("end"))
                {                   
                    break;
                }

                foreach (char c in virus)
                {
                    virusPower += c;
                }

                virusPower = virusPower / 3;
                time = virusPower * virus.Length;


                if (viruses.ContainsKey(virus))
                {
                    viruses[virus] = time / 3;
                }
                else
                {
                    viruses.Add(virus, time);
                }

                currentHealth -= viruses[virus];
                int minutes = viruses[virus] / 60;
                int seconds = viruses[virus] % 60;

                Console.WriteLine("Virus {0}: {1} => {2} seconds", virus, virusPower, viruses[virus]);
                if (currentHealth <= 0) break;
                Console.WriteLine("{0} defeated in {1}m {2}s.", virus, minutes, seconds);
                Console.WriteLine("Remaining health: {0}", currentHealth);

                currentHealth += (int)(currentHealth * 0.2);
                finalHealth = currentHealth;
                if (currentHealth + (int)(currentHealth * 0.2) > virusPower)
                {
                    currentHealth = immuneSystem;
                }

                
            }

            if (immuneSystem > 0)
            {
                Console.WriteLine("Final health: {0}", finalHealth);
            }
            else
            {
                Console.WriteLine("Immune System Defeated.");
            }
        }
    }
}
