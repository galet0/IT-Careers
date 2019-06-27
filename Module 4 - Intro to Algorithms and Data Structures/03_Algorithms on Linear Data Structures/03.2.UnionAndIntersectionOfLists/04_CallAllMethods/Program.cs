using System;
using System.Collections.Generic;

namespace _04_CallAllMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            firstList.Add(1); firstList.Add(2); firstList.Add(3); firstList.Add(4); firstList.Add(5); Console.Write("firstList=");
            PrintList(firstList);
            List<int> secondList = new List<int>();
            secondList.Add(2); secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);
            List<int> unionList = Union(firstList, secondList);
            Console.Write("union = ");
            PrintList(unionList);
            List<int> intersectList = Intersect(firstList, secondList);
            Console.Write("intersect = ");
            PrintList(intersectList);
        }

        private static List<int> Union(List<int> list1, List<int> list2)
        {
            List<int> unionList = new List<int>();

            unionList.AddRange(list1);
            foreach (int num in list2)
            {
                if (!unionList.Contains(num))
                {
                    unionList.Add(num);
                }

            }
            return unionList;
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
