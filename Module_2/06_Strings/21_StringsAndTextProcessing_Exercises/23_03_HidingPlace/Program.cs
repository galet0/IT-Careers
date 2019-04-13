using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_03_HidingPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            string[] clues = Console.ReadLine().Split();
            // asd@@asdasd@@@@@@@asdasd asdsad
            //@ 5
            while (true)
            {
                string searchedChar = clues[0];
                int minCount = int.Parse(clues[1].ToString());
                string pattern = new string(searchedChar[0], minCount);
                int index = map.IndexOf(pattern);
                int counter = 0;
                if(index != -1)
                {
                    for (int i = index; i < map.Length; i++)
                    {
                        if (searchedChar.Equals(map[i].ToString()))
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                
                if(counter > minCount)
                {
                    Console.WriteLine("Hideout found at index {0} " +
                        "and it is with size {1}!", index, counter);
                    break;
                }
                clues = Console.ReadLine().Split();
            }
            
        }
    }
}
