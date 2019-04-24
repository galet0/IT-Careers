using System;

namespace _02_DataValidations_ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                double surfaceArea = box.GetSurfaceArea();
                double lateralSurfaceArea = box.GetLateralSurfaceArea();
                double volume = box.GetVolume();
                Console.WriteLine("Surface area - {0:f2}", surfaceArea);
                Console.WriteLine("Lateral surface area - {0:f2}", lateralSurfaceArea);
                Console.WriteLine("Volume - {0:f2}", volume);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            
        }
    }
}
