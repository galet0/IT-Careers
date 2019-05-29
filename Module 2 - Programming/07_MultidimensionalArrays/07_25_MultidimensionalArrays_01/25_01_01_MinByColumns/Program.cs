using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_03_MinByColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colsInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colsInput[col];
                }
            }
            //3
            //4
            //1 2 3 5
            //8 6 9 4
            //5 8 4 3
            //1 2 3 3

            int[] minElements = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                int min = int.MaxValue;
                for (int row = 0; row < rows; row++)
                {
                    min = Math.Min(min, matrix[row, col]);
                    //Console.WriteLine(matrix[row, col]);
                }
                minElements[col] = min;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0, 2}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < cols; i++)
            {
                Console.Write("{0, 2}", minElements[i]);
            }
            Console.WriteLine();
            /*for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }*/
        }
    }
}
