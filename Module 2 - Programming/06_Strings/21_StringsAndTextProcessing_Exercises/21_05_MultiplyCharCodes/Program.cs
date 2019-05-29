using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_05_MultiplyCharCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];//Gosho
            string second = input[1];//Pesho
            int maxLength = Math.Max(first.Length, second.Length);
            int minLength = Math.Min(first.Length, second.Length);
            int totalSum = 0;

            //a aaaa
            if(first.Length == second.Length)
            {
                for (int i = 0; i < maxLength; i++)
                {
                    totalSum += first[i] * second[i];
                }
            }
            else if(first.Length < second.Length)
            {
                //aaa aaaa
                //minLength maxLentgh
                for (int i = 0; i < minLength; i++)
                {
                    totalSum += first[i] * second[i];
                }
                for (int i = minLength; i < maxLength; i++)
                {
                    totalSum += second[i];
                }
            }
            else
            {
                //aaaa aaa
                //minLength maxLentgh
                for (int i = 0; i < minLength; i++)
                {
                    totalSum += first[i] * second[i];
                }
                for (int i = minLength; i < maxLength; i++)
                {
                    totalSum += first[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
