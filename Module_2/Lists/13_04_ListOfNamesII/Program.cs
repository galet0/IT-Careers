using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13_04_ListOfNamesII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(',').ToList();

            for (int i = 0; i < names.Count; i++)
            {
                List<string> currName = names[i].Split(' ').ToList();
                currName.Reverse();
                /*for (int j = currName.Count - 1; j >= 0; j --)
                {
                    if(currName[j] != "")
                    {
                        Console.Write(currName[j] + " ");
                    }
                }*/
                Console.WriteLine(string.Join(" ", currName));
            }

        }
    }
}
