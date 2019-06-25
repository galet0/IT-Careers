using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> queue = new CircularQueue<int>();

            queue.Enqueue(3);
            queue.Enqueue(8);
            queue.Enqueue(6);

            Console.WriteLine(queue.Count);
        }
    }
}
