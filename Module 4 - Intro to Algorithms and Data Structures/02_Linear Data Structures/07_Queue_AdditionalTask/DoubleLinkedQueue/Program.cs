using System;

namespace DoubleLinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<string> queue = new CustomQueue<string>();

            queue.Enqueue("Pesho");
            queue.Enqueue("Gosho");
            queue.Enqueue("Marto");
            queue.Enqueue("Krisi");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
