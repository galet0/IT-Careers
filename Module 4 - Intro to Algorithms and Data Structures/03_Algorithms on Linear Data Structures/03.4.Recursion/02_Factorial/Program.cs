using System;

namespace _02_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        public static ulong Factorial(ulong num)
        {
            if(num == 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}
