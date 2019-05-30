﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InsertMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // O(N)
            List<int> startNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalNumbers = new List<int>();
            int numberToInsert = int.Parse(Console.ReadLine());

            // O(N^2)
            for (int i = 0; i < startNumbers.Count; i++)
            {
                if(startNumbers[i] == numberToInsert)
                {
                    finalNumbers = startNumbers;
                    startNumbers.Insert(i, numberToInsert); 
                }                   
            }

            // 2 * O(N)
            Console.WriteLine(String.Join(" ", finalNumbers));
            Console.WriteLine(String.Join(" ", startNumbers));

            // Total: O(N) + O(N^2) + 2*O(N) = O(N^2)
    }
}
