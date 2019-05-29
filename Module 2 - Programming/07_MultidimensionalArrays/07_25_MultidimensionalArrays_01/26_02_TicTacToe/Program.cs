using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            //X - O
            //- X O
            //- - X
            int size = 3;
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            bool hasWinner = false;
            for (int row = 0; row < size; row++)
            {
                int col = 0;
                if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row, col + 2])
                {
                    hasWinner = true;
                    Console.WriteLine("The winner is: {0}", matrix[row, col]);
                }
            }
            for (int col = 0; col < size; col++)
            {
                int row = 0;
                if (matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 2, col])
                {
                    hasWinner = true;
                    Console.WriteLine("The winner is: {0}", matrix[row, col]);
                }
            }

            int mRow = 0;
            int mCol = 0;
            if (matrix[mRow, mCol] == matrix[mRow + 1, mCol + 1] && matrix[mRow + 1, mCol + 1] == matrix[mRow + 2, mCol + 2])
            {
                hasWinner = true;
                Console.WriteLine("The winner is: {0}", matrix[mRow, mCol]);
            }
            else if (matrix[mRow + 2, mCol] == matrix[mRow + 1, mCol + 1] && matrix[mRow + 1, mCol + 1] == matrix[mRow, mCol + 2])
            {
                hasWinner = true;
                Console.WriteLine("The winner is: {0}", matrix[mRow, mCol]);
            }

            if(hasWinner == false)
            {
                Console.WriteLine("There is no winner!");
            }
        }

    }

}
