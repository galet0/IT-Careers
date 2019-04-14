using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_04_19_ItKarieri_Constructors_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
            //Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1
            //fragile

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Car>> data = new Dictionary<string, List<Car>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                //за двигателя
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                //за товара
                int weight = int.Parse(input[3]);
                string type = input[4];

                //за да създадем кола
                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);

                Car car = new Car(model, engine, cargo);
                for (int j = 5; j < input.Length; j+=2)
                {
                    double pressure = double.Parse(input[j]);
                    int age = int.Parse(input[j + 1]);
                    Tire tire = new Tire(pressure, age);
                    car.AddTire(tire);
                }

                if (!data.ContainsKey(type))
                {
                    data.Add(type, new List<Car>());
                }

                data[type].Add(car);
            }

            string cargoType = Console.ReadLine();
            List<string> cargos = CarsModels(cargoType, data);

            foreach(string model in cargos)
            {
                Console.WriteLine(model);
            }
        }
        
        private static List<string> CarsModels(string cargoType, Dictionary<string, List<Car>> data)
        {
            List<string> cargos = new List<string>();

            //Ако командата е “fragile”, то отпечатайте всички коли с тип на товара “fragile” с гуми с налягане < 1;
            if (cargoType.Equals("fragile"))
            {
                foreach (var kvp in data)
                {
                    if (kvp.Key.Equals("fragile"))
                    {
                        kvp.Value
                            //където за всеки обект car вземаме списъка с гуми и проверяваме (c.Tires.Any)
                            //дали някой елемент от списъка отговаря на даденото условие (t => t.Pressure < 1).
                            .Where(c => c.Tires.Any(t => t.Pressure < 1))
                            //избираме само модела на колата
                            .Select(c => c.Model)
                            .ToList()
                            //и един foreach да изведе моделите на намерените коли по тези критерии
                            .ForEach(m => cargos.Add(m));
                    }
                }
            }
            else if (cargoType.Equals("flamable"))
            {
                foreach (var kvp in data)
                {
                    if (kvp.Key.Equals("flamable"))
                    {
                        kvp.Value
                            //търсим в списъка с коли в речника чийто ключ е равен на flamable
                            //избираме само колите, които има двигател с мощност повече от 250.                            
                            .Where(c => c.Engine.Power > 250)
                            //избираме само модела на колата
                            .Select(c => c.Model)
                            .ToList()
                            //и един foreach да изведе моделите на намерените коли по тези критерии
                            .ForEach(m => cargos.Add(m));
                    }
                }
            }

            return cargos;
        }
    }
}
