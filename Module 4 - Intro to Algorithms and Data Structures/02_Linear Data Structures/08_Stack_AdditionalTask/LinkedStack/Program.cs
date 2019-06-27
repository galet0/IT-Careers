using System;

namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> stack = new LinkedStack<int>();

            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            int[] arr = stack.ToArray();

            Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine(stack.Pop());
        }
    }
}
