using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> threeNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int countToTake = threeNums[0];
            int countToDelete = threeNums[1];
            int searchedNum = threeNums[2];

            List<int> result = new List<int>();
            //Първото от тях показва броя на елементите, 
            //които трябва да вземете от списъка (считано от първия елемент). 
            for (int i = 0; i < countToTake; i++)
            {
                result.Add(numbers[i]);
            }
            //Второто число показва броя на елементите, 
            //които трябва да изтриете от елементите, които взехте (считано от първия елемент). 
            for (int i = 0; i < countToDelete; i++)
            {
                result.RemoveAt(0);
            }

            //Последното число е това, което търсим в получения списък след манипулациите. 
            int index = result.IndexOf(searchedNum);
            if(index != -1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
