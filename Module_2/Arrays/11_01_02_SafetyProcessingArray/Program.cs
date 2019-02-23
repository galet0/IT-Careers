using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_02_SafetyProcessingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] command = Console.ReadLine().Split();
            while(command[0] != "END")
            {
                switch (command[0])
                {
                    case "Add": 
                        if(command.Length == 2)
                        {
                            input = Add(input, command[1]);
                            Console.WriteLine(string.Join(" ", input)); 
                        }
                        else
                        {
                            input = Add(input, command[1], int.Parse(command[2]));
                            Console.WriteLine(string.Join(" ", input)); 
                        }
                        break;
                    case "Remove":
                        input = Remove(input, command[1]);
                        Console.WriteLine(string.Join(" ", input)); break;
                    case "Distinct": input = Distinct(input);
                        Console.WriteLine(string.Join(" ", input)); break;
                    case "Reverse": input = Reverse(input);
                        Console.WriteLine(string.Join(" ", input)); break;
                    case "Replace":
                        input = Replace(input,
                                        int.Parse(command[1]),
                                        command[2]);
                        Console.WriteLine(string.Join(" ", input));
                        break;
                    //default: Console.WriteLine("Invalid input!"); break;
                }
                
                command = Console.ReadLine().Split();
            }
        }        

        static string[] Distinct(string[] array)
        {
            int counter = 0;

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
            bool hasSuchIndex = true;
            for (int i = 0; i < array.Length; i++)
            {
                if(index >= 0 && index < array.Length)
                {
                    if (index == i)
                    {
                        array[i] = word;
                    }
                }
                else
                {
                    hasSuchIndex = false;
                    break;
                }
            }
            if (!hasSuchIndex)
            {
                Console.WriteLine("Invalid input!");
            }
            return array;
        }

        static string[] Add(string[] array, string item)
        {
            string[] result = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            result[result.Length - 1] = item;

            return result;
        }

        static string[] Add(string[] array, string item, int index)
        {
            string[] result = new string[array.Length + 1];
            for (int i = 0; i < result.Length; i++)
            {
                if (index > 0 && index < result.Length)
                {
                    if (index == i)
                    {
                        result[i] = item;
                    }
                    else
                    {
                        result[i] = array[i];
                    }
                }
                else
                {
                    return array;
                }
            }
            return result;
        }

        static string[] Remove(string[] array, string item)
        {
            string[] result = new string[array.Length - 1];
            for (int i = 0; i < result.Length; i++)
            {
                if (item == array[i])
                {
                    result[i] = array[i + 1];
                }
                else
                {
                    result[i] = array[i];
                }
            }
            return result;
        }
    }
}
