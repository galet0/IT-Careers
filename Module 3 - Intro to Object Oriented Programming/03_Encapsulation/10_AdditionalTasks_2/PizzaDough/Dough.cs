using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDough
{
    class Dough
    {
        //constants
        public static double Calories = 2;
        public static double DoughMinWeight = 1;
        public static double DoughMaxWeight = 200;

        //fields
        private string flourType;
        private string backingTechnique;
        private double weight;

        //constructor
        public Dough(string flourType, string backingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.Weight = weight;
        }              

        //getters setters
        public string FlourType
        {
            get { return this.flourType; }
            private set
            {
                if (!this.isFlourTypeValid(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BackingTechnique
        {
            get { return this.backingTechnique; }
            private set
            {
                if (!this.isBackingTechniqueValid(value))
                {
                    throw new ArgumentException("Invalid backing technique.");
                }

                this.backingTechnique = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < Dough.DoughMinWeight || value > Dough.DoughMaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{Dough.DoughMinWeight}..{Dough.DoughMinWeight}].");
                }
                this.weight = value;
            }
        }

        //public method for calories
        public double GetDoughCalories()
        {
            return CalculateCalories();
        }
        
        //проверява дали типа на брашното е white Или wholegrain
        private bool isFlourTypeValid(string flourType)
        {
            bool isValid = false;
            if(flourType.ToLower().Equals("white") 
                || flourType.ToLower().Equals("wholegrain"))
            {
                isValid = true;
            }

            return isValid;
        }

        private bool isBackingTechniqueValid(string backingTechnique)
        {
            bool isValid = false;
            if (backingTechnique.ToLower().Equals("crispy") 
                || backingTechnique.ToLower().Equals("chewy")
                || backingTechnique.ToLower().Equals("homemade"))
            {
                isValid = true;
            }

            return isValid;
        }

        //спрямо какъв е типа на брашното връща неговия модификатор
        private double GetFlourModifier()
        {
            double modifier = 0;

            switch (this.FlourType.ToLower())
            {
                case "white":
                    modifier = 1.5;
                    break;
                case "wholegrain":
                    modifier = 1.0;
                    break;
            }

            return modifier;
        }

        //спрямо каква е техниката на изпичане връща неговия модификатор
        private double GetBackingTechniqueModifier()
        {
            double modifier = 0;

            switch (this.BackingTechnique.ToLower())
            {
                case "crispy":
                    modifier = 0.9;
                    break;
                case "chewy":
                    modifier = 1.1;
                    break;
                case "homemade":
                    modifier = 1.0;
                    break;
            }

            return modifier;
        }

        //изчислява калориите на тестото по следната формула
        private double CalculateCalories()
        {
            return Dough.Calories * this.Weight * this.GetFlourModifier() * this.GetBackingTechniqueModifier();
        }
    }
}
