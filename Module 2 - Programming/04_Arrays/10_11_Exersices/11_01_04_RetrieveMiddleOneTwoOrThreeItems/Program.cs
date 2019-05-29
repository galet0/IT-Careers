using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_04_RetrieveMiddleOneTwoOrThreeItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int length = arr.Length;
            if(length == 1)
            {
                Console.WriteLine("{ " + string.Join(", ", arr) + " }");
            }
            //1 2 3 4
            else if(length % 2 == 0)
            {
                Console.WriteLine("{ " + arr[length / 2 - 1] + ", "
                                        + arr[length / 2] + " }");
            }
            //0 1 2 3 4
            //1 2 3 4 5 ->5 / 2 - 1; 5 / 2 -> 2; 5 / 2 + 1
            else
            {
                Console.WriteLine("{ " + arr[length / 2 - 1] + ", " 
                                        + arr[length / 2] + ", " 
                                        + arr[length / 2 + 1] + " }");
            }
        }
    }
}
