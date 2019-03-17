using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_04_LottaryTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int rows = nums[0];
            int cols = nums[1];
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
            //mainDiagonal
            //secondaryDiagonal
            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int upperDiagonalSum = 0;
            int lowerDiagonalSum = 0;
            double profit = 0;
            int mainDiagonalEvenSum = 0;
            int evenNumbersRows = 0;
            int oddNumbersCols = 0;
            bool isWinning = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col)
                    {
                        mainDiagonalSum += matrix[row, col];
                        if (matrix[row, col] % 2 == 0)
                        {
                            mainDiagonalEvenSum += matrix[row, col];
                        }
                    }
                    else if (row < col)
                    {
                        upperDiagonalSum += matrix[row, col];
                    }
                    else
                    {
                        lowerDiagonalSum += matrix[row, col];
                        //profit += lowerDiagonalSum;
                    }
                    if(row + col == rows - 1)
                    {
                        secondaryDiagonalSum += matrix[row, col];
                    }
                    if ((row == 0 || row == matrix.GetLength(0) - 1)
                        && matrix[row,col] % 2 == 0)
                    {
                        evenNumbersRows += matrix[row, col];
                    }
                    if((col == 0 || col == matrix.GetLength(1)- 1)
                        && matrix[row, col] % 2 != 0)
                    {
                        oddNumbersCols += matrix[row, col];
                    }
                }
                
            }
            //Console.WriteLine(mainDiagonalSum);
            //Console.WriteLine(secondaryDiagonalSum);
            if(mainDiagonalSum == secondaryDiagonalSum
                && upperDiagonalSum % 2 == 0 
                && lowerDiagonalSum % 2 != 0)
            {
                isWinning = true;
            }
            if (isWinning)
            {
                profit = lowerDiagonalSum + mainDiagonalEvenSum + evenNumbersRows + oddNumbersCols;
                Console.WriteLine("YES");
                Console.WriteLine("The amount of money won is: {0:f2}", profit / 4);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
