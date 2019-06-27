using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Demo_Union_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>() { 4, 5, 6, 7 };
            List<int> secondList = new List<int>() { 5, 6, 8, 9, 10 };

            List<int> unionList = new List<int>();
            unionList.AddRange(firstList);

            //unionList.AddRange(secondList.Where(x => !firstList.Contains(x)));
            //PrintList(unionList);

            for (int i = unionList.Count - 1; i >= 0; i--)
            {
                if (secondList.Contains(unionList[i]))
                {
                    unionList.RemoveAt(i);
                }
            }

            unionList.AddRange(secondList);
            Console.Write("union = ");
            PrintList(unionList);

        }

        private static void PrintList(List<int> list)
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
