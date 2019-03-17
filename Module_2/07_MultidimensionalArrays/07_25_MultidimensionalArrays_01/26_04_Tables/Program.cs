using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_04_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheets = int.Parse(Console.ReadLine());
            int[][,] document = new int[sheets][,];

            for (int i = 0; i < sheets; i++)
            {
                int[] sizes = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                document[i] = new int[sizes[0], sizes[1]];

                for (int row = 0; row < document[i].GetLength(0); row++)
                {
                    int[] rowArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int col = 0; col < document[i].GetLength(1); col++)
                    {
                        document[i][row, col] = rowArray[col];
                    }
                }
            }

            double sumAll = 0.0;
            for (int i = 0; i < sheets; i++)
            {
                int min = document[i][0, 0];
                int max = document[i][0, 0];
                double sum = 0;
                for (int row = 0; row < document[i].GetLength(0); row++)
                {
                    for (int col = 0; col < document[i].GetLength(1); col++)
                    {
                        if(document[i][row, col] < min)
                        {
                            min = document[i][row, col];
                        }

                        if(document[i][row, col] > max)
                        {
                            max = document[i][row, col];
                        }

                        sum += document[i][row, col];
                    }
                }

                double avg = sum / (document[i].GetLength(0) * document[i].GetLength(1));
                sumAll += avg;
                Console.WriteLine("{0} {1} {2}", min, max, Math.Round(avg, 2));
            }

            double globalAvg = sumAll / sheets;
            for (int i = 0; i < sheets; i++)
            {
                int counter = 0;
                for (int row = 0; row < document[i].GetLength(0); row++)
                {
                    for (int col = 0; col < document[i].GetLength(1); col++)
                    {
                        if(document[i][row, col] > globalAvg)
                        {
                            counter++;
                        }
                    }
                }

                Console.Write("{0} ", counter);
            }

            Console.WriteLine();
        }
    }
}
