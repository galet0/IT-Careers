using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            string input = Console.ReadLine();
            while (true)
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    //push {element} – добавяте елемента в края на редицата от числа
                    case "push":
                        nums.Add(int.Parse(command[1]));
                        break;
                    //pop – вземате елемента, който се намира на последна позиция, принтирате го и го изтривате
                    case "pop":
                        int last = nums.Last();
                        Console.WriteLine(last);
                        nums.Remove(last);
                        //Console.WriteLine(string.Join(" ", nums));
                        break;
                    //shift – вземате последния елемент и го слагате като начален, 
                    //а началния елемент отива на последно място
                    case "shift":
                        int swap = nums[nums.Count - 1];
                        nums[nums.Count - 1] = nums[0];
                        nums[0] = swap;
                        //Console.WriteLine(string.Join(" ", nums));
                        break;
                    //addMany {position} {element element element} – след името на командата получавате позиция, 
                    //на която трябва да вмъкнете поредицата дадена към командата, ако такaва позиция съществува
                    case "addMany":
                        int index = int.Parse(command[1]);

                        if(index > 0 && index < nums.Count)
                        {
                            for (int i = 2; i < command.Length; i++)
                            {
                                int number = int.Parse(command[i]);
                                nums.Insert(index, number);
                                index++;
                            }                        
                        }
                        //Console.WriteLine(string.Join(" ", nums));
                        break;
                    //remove {position} – премахнете елемента, който се намира на дадената позицията, 
                    //ако такава позиция съществува
                    case "remove":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    //print – приключва изпълнението на програмата и принтирате резултатната колекция обърната наобратно, 
                    //а всеки елемент трябва да бъде разделен от следващия със запетая и интервал
                    case "print":
                        nums.Reverse();
                        Console.WriteLine(string.Join(", ", nums));                        
                        break;
                }
                if (input.Equals("print"))
                {
                    break;
                }
                input = Console.ReadLine();
                
            }
        }
    }
}
