using System;

namespace _02_InnerLoops_and_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] loops = new int[n];
            Permutation(loops, 0);
        }

        public static void Permutation(int[] loops, int index)
        {
            if(index > loops.Length - 1)
            {
                Console.WriteLine(string.Join(" ", loops));
            }

            for (int i = 1; i <= loops.Length && index < loops.Length; i++)
            {
                loops[index] = i;
                Permutation(loops, index + 1);
            }
            //Console.WriteLine($"{i1} {i2}");

        }
    }
}
