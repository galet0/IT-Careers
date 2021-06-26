using System;

namespace _01_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", Reverse(array, 0)));
        }

        public static int[] Reverse(int[] array, int index)
        {
            if(index > (array.Length - 1) / 2)
            {                
                return array;
            }
            //0 1 2 3
            //1 2 3 4
            //4 3 2 1
            int temp = array[index];
            array[index] = array[array.Length - 1 - index];
            array[array.Length - 1 - index] = temp;
            Reverse(array, index + 1);
            return array;
        }
    }
}
