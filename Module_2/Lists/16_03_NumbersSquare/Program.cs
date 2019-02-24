using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03_NumbersSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> squares = new List<int>();
                
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                if(Math.Sqrt(currNum) == (int)Math.Sqrt(currNum))
                {
                    squares.Add(currNum);
                }
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
