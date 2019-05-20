using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsKingdom
{
    class Dish
    {
        private string name;
        private string foodGroup;
        private double price;

        public Dish(string name, string foodGroup, double price)
        {
            this.Name = name;
            this.FoodGroup = foodGroup;
            this.Price = price;
        }



        public string Name
        {
            get { return this.name;  }
            private set { this.name = value; }
        }



        public string FoodGroup
        {
            get { return this.foodGroup; }
            private set { this.foodGroup = value; }
        }



        public double Price
        {
            get { return this.price; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid dish price");
                }

                this.price = value;
            }
        }



        public override string ToString()
        {
            return string.Format("Dish: {0} of type {1}. Price {2:f2}", this.Name, this.FoodGroup, this.Price);
        }
    }
}
