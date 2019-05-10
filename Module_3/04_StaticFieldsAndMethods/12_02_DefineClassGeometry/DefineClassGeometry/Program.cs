using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            //square
            Console.Write("Enter the side of a Square: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("--> Square Area = {0}", Geometry.SquareArea(side));
            Console.WriteLine("--> Square Perimeter = {0}", Geometry.SquarePerimeter(side));

            //rectangle
            Console.Write("Enter side A of the Rectangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side B of the Rectangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("--> Rectangle Area = {0}", Geometry.RectangleArea(a, b));
            Console.WriteLine("--> Rectangle Perimeter = {0}", Geometry.RectanglePerimeter(a, b));

            //circle
            Console.Write("Enter radius of the circle: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("--> Circle Area = {0}", Geometry.CircleArea(r));
        }
    }
}
