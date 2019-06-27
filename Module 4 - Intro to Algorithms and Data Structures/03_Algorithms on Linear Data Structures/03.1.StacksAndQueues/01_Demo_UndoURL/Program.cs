using System;
using System.Collections.Generic;

namespace _01_Demo_UndoURL
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pages = new Stack<string>();

            string command = Console.ReadLine();
            string previous = null;

            while (!"exit".Equals(command))
            {
                /*Вариант 1
                if(command.Equals("back"))
                {
                    if(pages.Count > 1)
                    {
                        pages.Pop();
                        Console.WriteLine(pages.Peek());
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    pages.Push(command);
                }

                command = Console.ReadLine();
               вариант 1 END*/

                //Вариант 2
                if (command.Equals("back"))
                {
                    if (pages.Count != 0)
                    {
                        Console.WriteLine(pages.Pop());
                    }
                    previous = null;
                }
                else
                {
                    if(previous != null)
                    {
                        pages.Push(previous);
                    }

                    previous = command;
                }

                command = Console.ReadLine();
            }
        }
    }
}
