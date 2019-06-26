using System;

namespace List_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<int> list = new ReversedList<int>();

            list.Add(2);
            list.Add(5);
            list.Add(7);
            list.Add(9);
            list.Add(1);
            list.Add(8);
            Console.WriteLine(list.RemoveAt(1));

            Console.WriteLine(string.Join(" ", list.GetReversed()));

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
