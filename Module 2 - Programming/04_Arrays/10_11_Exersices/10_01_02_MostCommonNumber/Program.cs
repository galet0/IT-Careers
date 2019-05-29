using System;

namespace _10_01_02_MostCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int[] numbers = new int[arrInput.Length];
            int mostCommonNumber = 0;
            int maxCounter = 1;

            for (int i = 0; i < arrInput.Length; i++)
            {
                numbers[i] = int.Parse(arrInput[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;                        
                    }
                    
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    mostCommonNumber = numbers[i];
                }
            }

            //Console.WriteLine("Counter: "+ maxCounter);
            Console.WriteLine(mostCommonNumber);
        }
    }
}
