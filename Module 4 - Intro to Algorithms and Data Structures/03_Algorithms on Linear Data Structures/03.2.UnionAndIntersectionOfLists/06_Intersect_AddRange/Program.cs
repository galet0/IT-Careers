using System;
using System.Collections.Generic;

namespace _06_Intersect_AddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>() { 4, 5, 6, 7 };
            List<int> secondList = new List<int>() { 5, 6, 8, 9, 10 };

            List<int> intersectList = new List<int>();
            intersectList.AddRange(firstList);

            //intersectList.RemoveAll(x => !secondList.Contains(x));
            //PrintList(intersectList);

            for (int i = intersectList.Count - 1; i >= 0; i--)
            {
                if (!secondList.Contains(intersectList[i]))
                {
                    intersectList.RemoveAt(i);
                }
            }
            Console.Write("intersect = ");
            PrintList(intersectList);

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
