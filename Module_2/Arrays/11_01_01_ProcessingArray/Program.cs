using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_01_ProcessingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "one", "two", "one", "three", "two", "five"};//Console.ReadLine().Split().ToArray();
            int numberOfRows = 1;//int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfRows; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Distinct": input = Distinct(input); break;
                    case "Reverse": input = Reverse(input); break;
                    case "Replace": input = Replace(input, 
                                                    int.Parse(command[1]), 
                                                    command[2]);
                                                    break;
                }
                //Console.WriteLine(command);
                //Console.WriteLine(index);
                //Console.WriteLine(word);
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static string[] Distinct(string[] array)
        {
            int counter = 0;
            

            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    counter++;
                }
            }

            string[] result = new string[counter];
            int freeIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    result[freeIndex] = array[i];
                    freeIndex++;
                }
            }

            return result;
        }

        static string[] Reverse(string[] array)
        {
            string[] result = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - 1 - i];
            }

            return result;
        }

        static string[] Replace(string[] array, int index, string word)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(index == i)
                {
                    array[i] = word;
                }
            }

            return array;
        }
    }
}
