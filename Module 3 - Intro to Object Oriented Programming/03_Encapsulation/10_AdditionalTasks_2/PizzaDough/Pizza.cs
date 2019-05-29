using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDough
{
    class Pizza
    {
        public static int ToppingsCountMin = 1;
        public static int ToppingsCountMax = 10;
        private readonly List<Topping> toppings;

        private string name;
        private Dough dough;
        private int toppingsCount;

        public Pizza(string name, Dough dough, int toppingsCount)
        {
            this.Name = name;
            this.Dough = dough;
            this.ToppingsCount = toppingsCount;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if(string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value)
                    || value.Length < Pizza.ToppingsCountMin 
                    || value.Length > Pizza.ToppingsCountMax)
                {
                    throw new ArgumentException($"Pizza name should be between {Pizza.ToppingsCountMin} and {Pizza.ToppingsCountMax} symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            private set
            {
                this.dough = value;
            }
        }
        
        public int ToppingsCount
        {
            get { return this.toppingsCount; }
            private set
            {
                if (value < Pizza.ToppingsCountMin
                    || value > Pizza.ToppingsCountMax)
                {
                    throw new ArgumentException($"Number of toppings should be in range [{Pizza.ToppingsCountMin}..{Pizza.ToppingsCountMax}].");
                }

                this.toppingsCount = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);            
        }

        public double GetPizzaCalories()
        {
            return CalculateCalories();
        }

        public override string ToString()
        {
            return $"{this.Name} - {string.Format("{0:f2}", this.GetPizzaCalories())} Calories.";
        }

        private double CalculateCalories()
        {
            double totalCalories = this.Dough.GetDoughCalories();
            foreach (Topping topping in this.toppings)
            {
                totalCalories += topping.GetToppingCalories();
            }

            return totalCalories;
        }
    }
}
