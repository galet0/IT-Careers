using System;
using System.Linq;

namespace _10_02_02_SwappingElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] swappedArr = new string[input.Length];
            //1 2 3 4 5 - elements
            //0 1 2 3 4 - indexes
            for (int i = 0; i < input.Length / 2; i++)
            {
                string firstElement = input[i]; 
                string lastElement = input[input.Length - 1 - i];//5 - 1 - 1
                string tempVar = lastElement; 
                lastElement = firstElement; 
                firstElement = tempVar;
                swappedArr[i] = firstElement;
                swappedArr[input.Length - 1 - i] = lastElement;
            }
            
            swappedArr[input.Length / 2] = input[input.Length / 2];
            Console.WriteLine(string.Join(" ", swappedArr));
        }
    }
}
