using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_01_StringArrayComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int minLength = Math.Min(arr1.Length, arr2.Length);
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minLength; i++)
                {
                    if (arr1.Length > arr2.Length)
                    {
                        if (arr1[i] == arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                            break;
                        }
                        else if(arr1[i] > arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));                            
                            break;
                        }
                    }
                    else
                    {
                        if (arr1[i] == arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));
                            break;
                           
                        }
                        else if (arr1[i] > arr2[i])
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                            break;
                        }
                    }

                }
            }

        }
    }
}
