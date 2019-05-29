using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_DeclareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrix = new int[3, 4];//3 rows 4 columns
            float[,,] floatCube = new float[5, 5, 5];
            Console.WriteLine();

            //двумерен масив 2 Х 4 (2 реда, 4 колони)
            int[,] matrix = 
            {
                //0c 1c 2c 3c
                { 2, 8, 3, 5},//0r
                { 7, 9, 0, 3} //1r
            };
            //Двумерен масив
            Console.WriteLine(matrix[1, 2]);
            Console.WriteLine(matrix[0, 3]);
            Console.WriteLine("Rows: " + matrix.GetLength(0));//Взема дължината на реда
            Console.WriteLine("Columns: " + matrix.GetLength(1));//Взема дължината на колоната

            //Тримерен масив
            Console.WriteLine("Rows: " + floatCube.GetLength(0));
            Console.WriteLine("Columns: " + floatCube.GetLength(1));
            Console.WriteLine("Depth: " + floatCube.GetLength(2));

            //Отпечатване на матрица
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
 
        }
    }
}
