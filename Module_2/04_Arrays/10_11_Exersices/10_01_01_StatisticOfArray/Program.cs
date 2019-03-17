using System;

namespace _10_01_01_StatisticOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int[] numbers = new int[arrInput.Length];
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < arrInput.Length; i++)
            {
                numbers[i] = int.Parse(arrInput[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                //min element
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }

                sum += numbers[i];                
            }

            avg = sum / numbers.Length;
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", avg);
        }
    }
}
