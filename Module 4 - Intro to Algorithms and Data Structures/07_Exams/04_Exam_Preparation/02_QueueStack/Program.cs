using System;

namespace _02_QueueStack
{
    class Program
    {
        static void Main(string[] args)
        {
            DinamycList<int> list = new DinamycList<int>();

            list.Enqueue(5);
            list.Enqueue(6);
            list.Push(4);
            //6 5 4
            Console.WriteLine(list.Dequeue());
            Console.WriteLine(list.Pop());
            Console.WriteLine();

            int[] arr = list.ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
