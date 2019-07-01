using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(9);
            list.AddLast(10);
            list.AddLast(11);

            //list.ForEach(Print);

            list.ForEach(delegate (int n)
            {
                Console.WriteLine(n);
            });
            Console.WriteLine();
            Console.WriteLine("Removed: " + list.RemoveFirst());
            list.ForEach(Print);

            Console.WriteLine("Removed: " + list.RemoveLast());
            list.ForEach(Print);

            int[] arr = list.ToArray();
            Console.WriteLine(string.Join(", ", arr));

            int sum = 0;
            foreach (int item in list)
            {
                sum += item;
            }

            Console.WriteLine("sum = {0}", sum);
            int[] reversed = list.Reverse();
            Console.WriteLine(string.Join(", ", reversed));

        }

        private static void Print(int item)
        {
            Console.WriteLine(item);
        }
    }
}
