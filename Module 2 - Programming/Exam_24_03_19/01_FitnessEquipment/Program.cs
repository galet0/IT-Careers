using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FitnessEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double treadmill = 5899;
            double crosstrainer = 1699;
            double exerciseBike = 1789;
            double dumbbells = 579;

            int n = int.Parse(Console.ReadLine());
            
            double totalSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                string fitnessEquipment = Console.ReadLine(); ;
                switch (fitnessEquipment)
                {
                    case "exercise bike":
                        totalSum += exerciseBike;
                        break;
                    case "treadmill":
                        totalSum += treadmill;
                        break;
                    case "dumbbells":
                        totalSum += dumbbells;
                        break;
                    case "cross trainer":
                        totalSum += crosstrainer;
                        break;
                }
            }

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
