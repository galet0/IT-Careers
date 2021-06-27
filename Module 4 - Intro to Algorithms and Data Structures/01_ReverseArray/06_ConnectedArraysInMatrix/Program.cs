using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ConnectedArraysInMatrix
{
    class Program
    {

        public static void FindPath(int row, int col, char direction)
        {
            if (!IsInBounds(row, col))
                return;
            else if (!IsVisited(row, col))
            {
                Mark(row, col, direction);
                FindPath(row, col + 1, 'R');
                FindPath(row + 1, col, 'D');
                FindPath(row, col - 1, 'L');
                FindPath(row - 1, col, 'U');
            }
        }
        public static bool IsInBounds(int row, int col)
        {
            if (row < 0 || col >= width || col < 0 || row >= height) return false;
            return true;
        }
        public static void Mark(int row, int col, char direction)
        {
            var copy = matrix[row].ToCharArray();
            copy[col] = '*';
            matrix[row] = string.Join("", copy);
            area++;
        }
        public static bool IsVisited(int row, int col)
        {
            if (matrix[row][col] == '*')
                return true;
            return false;
        }
        public static bool FindStartingCell()
        {
            for (int i = 0; i < height; i++)
                for (int y = 0; y < width; y++)
                    if (matrix[i][y] == '-')
                    {
                        dic.Add(new Region(y, i, 0));
                        return true;
                    }
            return false;
        }
        public static void DrawMatrix()
        {
            for (int i = 0; i < height; i++)
                matrix[i] = Console.ReadLine();
        }
        public static int height = int.Parse(Console.ReadLine());
        public static int width = int.Parse(Console.ReadLine());
        public static string[] matrix = new string[height];
        public static int area = 0;
        public static List<Region> dic = new List<Region>();
        static void Main(string[] args)
        {
            DrawMatrix();
            int counter = 0;
            int row = 0, col = 0;
            while (FindStartingCell() == true)
            {
                area = 0;
                row = dic[counter].Y; col = dic[counter].X;
                FindPath(row, col, '0');
                dic[counter].Area = area;
                counter++;
            }
            Console.WriteLine("Areas found: {0}", dic.Count);
            dic = dic.OrderByDescending(x => x.Area).ToList();
            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine($"Area #{i + 1} at ({dic[i].Y},{dic[i].X}), size: {dic[i].Area}");
            }
        }
    }
    public class Region
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Area { get; set; }
        public Region(int x, int y, int area = 0)
        {
            X = x;
            Y = y;
            Area = area;
        }
    }
}
