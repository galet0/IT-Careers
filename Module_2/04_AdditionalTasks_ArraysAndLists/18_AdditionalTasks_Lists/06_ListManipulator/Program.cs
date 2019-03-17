using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                //	print – спира да получава повече команди и извежда последното състояние на списъка.
                if (line.Equals("print"))
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }

                string[] commands = line.Split();
                switch (commands[0])
                {
                    //add <индекс> <елемент> – вмъква елемент на зададената позиция 
                    //(елементите надясно от тази позиция включително се изместват надясно).
                    case "add":
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        numbers.Insert(index, element);
                        break;
                    //addMany<индекс> < елемент 1 > < елемент 2 > … < елемент n > – 
                    //добавя множество от елементи на дадената позиция.
                    case "addMany":
                        int position = int.Parse(commands[1]);
                        List<int> numsToAdd = new List<int>();
                        for (int i = 2; i < commands.Length; i++)
                        {
                            numsToAdd.Add(int.Parse(commands[i]));
                        }
                        numbers.InsertRange(position, numsToAdd);
                        break;
                    //contains < елемент > – изпечатва индекса на първото срещане 
                    //на зададения елемент(ако съществува) в списъка или - 1, ако елемента не е открит.
                    case "contains":
                        int containsIndex = numbers.IndexOf(int.Parse(commands[1]));
                        Console.WriteLine(containsIndex);
                        break;
                    //remove < индекс > – премахва елемента, намиращ се на зададената позиция
                    case "remove":
                        numbers.RemoveAt(int.Parse(commands[1]));
                        break;
                        //shift < позиции > – отмества всеки елемент от списъка 
                        //съответния брой позиции наляво(с ротация).
                    //Например, [1, 2, 3, 4, 5] -> shift 2-> [3, 4, 5, 1, 2]
                    case "shift":
                        int positionsCount = int.Parse(commands[1]);
                        List<int> itemsToShift = numbers.Take(positionsCount).ToList();
                        List<int> leftItems = numbers.Skip(positionsCount).ToList();
                        numbers = leftItems.Concat(itemsToShift).ToList();
                        break;
                    //	sumPairs – сумира елементите на всички двойки в списъка(първа + втора, трета + четвърта, …).
                    //Например, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
                    case "sumPairs":
                        int indexToSum = 0;

                        for (int i = 0; i < numbers.Count-1; i++)
                        {
                            numbers[i] = numbers[indexToSum] + numbers[indexToSum + 1];
                            indexToSum++;
                        }
                        break;
                    
                }

            }


        }
    }
}
