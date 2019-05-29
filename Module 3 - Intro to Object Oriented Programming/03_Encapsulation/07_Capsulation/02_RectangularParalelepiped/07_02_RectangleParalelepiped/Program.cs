using System;

namespace _07_02_RectangleParalelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);
            double surfaceArea = box.GetSurfaceArea();
            double lateralSurfaceArea = box.GetLateralSurfaceArea();
            double volume = box.GetVolume();
            Console.WriteLine("Surface area - {0:f2}", surfaceArea);
            Console.WriteLine("Lateral surface area - {0:f2}", lateralSurfaceArea);
            Console.WriteLine("Volume - {0:f2}", volume);
        }
    }
}
