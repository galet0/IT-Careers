using System;
using System.Collections.Generic;

namespace _01_Demo_Union
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 4, 5, 6, 7};
            List<int> list2 = new List<int>() { 5, 6, 8, 9, 10};

            //union
            //4, 5, 6,7,8, 9, 10
            Console.WriteLine(string.Join(", ", Union(list1, list2)));
        }

        public static List<int> Union(List<int> list1, List<int> list2)
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

    }
}
