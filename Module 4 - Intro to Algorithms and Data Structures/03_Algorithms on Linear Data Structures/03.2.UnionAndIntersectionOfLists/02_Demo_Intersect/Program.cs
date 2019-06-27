using System;
using System.Collections.Generic;

namespace _02_Demo_Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 4, 5, 6, 7 };
            List<int> list2 = new List<int>() { 5, 6, 8, 9, 10 };

            //intersect
            //5, 6
            Console.WriteLine(string.Join(", ", Intersect(list1, list2)));
        }

        private static List<int> Intersect(List<int> list1, List<int> list2)
        {
            List<int> intersect = new List<int>();

            foreach (int item in list1)
            {
                if (list2.Contains(item))
                {
                    intersect.Add(item);
                }
            }

            return intersect;
        }
    }
}
