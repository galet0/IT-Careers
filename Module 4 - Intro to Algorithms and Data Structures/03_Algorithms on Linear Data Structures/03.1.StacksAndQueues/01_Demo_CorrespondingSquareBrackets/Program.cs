using System;
using System.Collections;
using System.Collections.Generic;

namespace _01_Demo_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> indexes = new Stack<int>();

            string expression = Console.ReadLine();

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if(expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    int length = i - startIndex + 1;

                    string substr = expression.Substring(startIndex, length);
                    Console.WriteLine(substr);
                }

            }

        }
    }
}
