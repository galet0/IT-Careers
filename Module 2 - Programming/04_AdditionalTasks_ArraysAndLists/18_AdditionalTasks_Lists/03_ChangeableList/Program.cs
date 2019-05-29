using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChangeableList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine();

            while (true)
            {
                if(line.Equals("Odd") || line.Equals("Even"))
                {
                    break;
                }
                string[] commands = line.Split();
                string command = commands[0];

                switch (command)
                {
                    case "Delete":
                        int numToDelete = int.Parse(commands[1]);
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if(nums[i] == numToDelete)
                            {
                                nums.Remove(nums[i]);
                            }
                        }
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        if(index >= 0 && index < nums.Count)
                        {
                            nums.Insert(index, numToInsert);
                        }
                        break;
                }

                line = Console.ReadLine();
            }

            if (line.Equals("Odd"))
            {                
                Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0).ToList()));
            }
            else if (line.Equals("Even"))
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0)));
            }
        }
    }
}
