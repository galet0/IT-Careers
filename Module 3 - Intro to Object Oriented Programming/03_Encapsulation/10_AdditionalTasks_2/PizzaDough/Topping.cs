using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDough
{
    class Topping
    {
        //constants
        public const double Calories = 2;
        public const double toppingMinWeight = 1;
        public const double toppingMaxWeight = 50;

        //fields
        private string toppingType;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        //getters setters
        public string ToppingType
        {
            get { return this.toppingType; }
            private set
            {
                if (!IsToppingTypeValid(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza");
                }

                this.toppingType = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if(value < Topping.toppingMinWeight || value > Topping.toppingMaxWeight)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [{Topping.toppingMinWeight}..{Topping.toppingMaxWeight}].");
                }

                this.weight = value;
            }
        }

        public double GetToppingCalories()
        {
            return this.CalculateCalories();
        }

        //check is topping type valid
        private bool IsToppingTypeValid(string toppingType)
        {
            bool isValid = false;

            if(toppingType.ToLower().Equals("meat")
                || toppingType.ToLower().Equals("veggies")
                || toppingType.ToLower().Equals("cheese")
                || toppingType.ToLower().Equals("sauce"))
            {
                isValid = true;
            }

            return isValid;
        }

        private double GetToppingModifier()
        {
            double modifier = 0;
            switch (this.ToppingType.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                case "sauce":
                    modifier = 0.9;
                    break;
            }

            return modifier;
        }

        private double CalculateCalories()
        {
            return Topping.Calories * this.Weight * this.GetToppingModifier();
        }
    }
}
