using System;
using System.Collections.Generic;

namespace _01_Demo_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //S = N, N+1, 2*N, N+2, 2*(N+1), 2*N+1, 4*N, ...
            //n = 3;
            //searched number = 16
            //index = 10;
            //    0  1  2  3  4  5  6   7   8  9  10  11 12
            //S = 3, 4, 6, 5, 8, 7, 12, 6, 10, 9, 16, 8, 14, …

            Queue<int> queue = new Queue<int>();

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int curr = 0;
            int position = 1;
            bool positionFound = false;

            queue.Enqueue(n);
            
            while (!positionFound)
            {
                curr = queue.Peek() + 1;
                queue.Enqueue(curr);
                position++;

                if (curr == p)
                {
                    positionFound = true;
                    break;
                }
                curr = queue.Peek() * 2;
                queue.Enqueue(curr);
                position++;
                if (curr == p)
                {
                    positionFound = true;
                    break;
                }

                queue.Dequeue();
                /*решение презентация
                int current = queue.Dequeue();
                index++;
                if (current == p)
                {
                    Console.WriteLine("Index = {0}", index);
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
                */
            }

            Console.WriteLine(position);

        }
    }
}
