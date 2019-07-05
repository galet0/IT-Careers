using System;
using System.Collections.Generic;

namespace _01_StretchingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> arr = new ArrayList<int>();

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr.Count);

            arr.Add(16);
            Console.WriteLine("RemoveAt" + arr.RemoveAt(3));
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr.Count);
        }
    }
}
