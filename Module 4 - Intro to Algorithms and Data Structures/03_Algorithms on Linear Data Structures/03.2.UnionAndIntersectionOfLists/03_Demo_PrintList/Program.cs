using System;
using System.Collections.Generic;

namespace _03_Demo_PrintList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 4, 5, 6, 7 };

            PrintList(list);
        }

        public static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }

    }
}
