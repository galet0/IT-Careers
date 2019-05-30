using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ExistNumberInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int searchedNumber = int.Parse(Console.ReadLine());
            bool doesExist = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (searchedNumber == numbers[i])
                {
                    doesExist = true;
                }
            }

            if (doesExist)
            {
                Console.WriteLine("{0} Exists in the list.", searchedNumber);
            }
            else
            {
                Console.WriteLine("{0} Not exists in the list.", searchedNumber);
            }
        }
    }
}
