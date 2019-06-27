using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(5);
            list.AddFirst(8);

            list.AddLast(6);

            //8 5 6
            //list.ForEach(Print);

            list.ForEach(delegate (int item)
            {
                Console.WriteLine(item);
            });

            //while(list.Count > 0)
            //{
            //    Console.WriteLine(list.RemoveFirst());
            //}
            //Console.WriteLine(list.RemoveFirst());

            //while (list.Count > 0)
            //{
            //    Console.WriteLine(list.RemoveLast());
            //}
            //Console.WriteLine(list.RemoveLast());

            int[] arr = list.ToArray();

            Console.WriteLine(string.Join(" ", arr));

            foreach (int item in list)
            {
                Console.WriteLine("-- {0} --", item);
            }

            int[] reversed = list.Reverse();
            Console.WriteLine(string.Join(", ", reversed));

        }

        private static void Print(int item)
        {
            Console.WriteLine(item);
        }
    }
}
