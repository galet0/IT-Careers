using System;

namespace PizzaDough
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            Pizza pizza = null;
            bool isValid = true;

            while (!(line = Console.ReadLine()).Equals("END"))
            {
                string[] info = line.Split();
                string name = info[1];
                int toppingsCount = int.Parse(info[2]);
                if(toppingsCount < Pizza.ToppingsCountMin || toppingsCount > Pizza.ToppingsCountMax)
                {
                    Console.WriteLine($"Number of toppings should be in range [{Pizza.ToppingsCountMin}..{Pizza.ToppingsCountMax}].");
                    break;
                }
                /// summary
                /// Pizza Bulgarian 2
                ///Dough Tip500 Balgarsko 100
                ///Topping Sirene 50
                ///Topping Cheese 50
                ///Topping Krenvirsh 20
                ///Topping Meat 10
                ///END
                ///
                if (info[0].Equals("Pizza"))
                {
                    string[] doughInfo = Console.ReadLine().Split();
                    string flourType = doughInfo[1];
                    string backingTechnique = doughInfo[2];
                    double weight = double.Parse(doughInfo[3]); 
                    Dough dough = CreateDough(flourType, backingTechnique, weight);
                    if(dough != null)
                    {
                        pizza = CreatePizza(name, dough, toppingsCount);
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                    
                }

                for (int i = 0; i < toppingsCount; i++)
                {
                    string[] toppingsInfo = Console.ReadLine().Split();
                    string toppingType = toppingsInfo[1];
                    double weight = double.Parse(toppingsInfo[2]);

                    Topping topping = null;
                    if(pizza != null)
                    {
                        topping = CreateTopping(toppingType, weight);
                        if (topping != null)
                        {
                            pizza.AddTopping(topping);
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                                      
                }

                if (!isValid)
                {
                    break;
                }

            }

            if (isValid)
            {
                Console.WriteLine(pizza);
            }
        }

        private static Pizza CreatePizza(string name, Dough dough, int toppingsCount)
        {
            Pizza pizza = null;
            try
            {
                pizza = new Pizza(name, dough, toppingsCount);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pizza;
        }

        private static Dough CreateDough(string flourType, string backingTechnique, double weight)
        {
            Dough dough = null;
            try
            {
                dough = new Dough(flourType, backingTechnique, weight);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dough;
        }

        private static Topping CreateTopping(string toppingType, double weight)
        {
            Topping topping = null;
            try
            {
                topping = new Topping(toppingType, weight);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return topping;
        }
    }
}
