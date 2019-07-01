using System;

namespace _03_PrintFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFigure(5);
        }

        public static void PrintFigure(int n)
        {
            if(n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));

            PrintFigure(n - 1);

            Console.WriteLine(new string('#', n));
        }
    }
}
