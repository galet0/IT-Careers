using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsKingdom
{
    class Chef
    {
        private string name;
        private string department;
        private List<Dish> dishes;
        private bool isOnABreak;

        public Chef(string name, string department)
        {
            this.Name = name;
            this.Department = department;
            this.dishes = new List<Dish>();
            this.IsOnABreak = false;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 3 || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid chef name!");
                }

                this.name = value;
            }
        }

        public string Department
        {
            get { return this.department; }
            private set
            {
                if (!value.Equals(value.ToUpper()) || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department name should be uppercase word!");
                }

                this.department = value;
            }
            
        }

        public bool IsOnABreak
        {
            get { return this.isOnABreak; }
            private set
            {
                this.isOnABreak = value;
            }
        }

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }



        public bool RemoveDish(Dish dish)
        {
            return this.dishes.Remove(dish);
        }



        public bool RemoveAllByFoodGroup(string foodGroup)
        {
            bool isRemoved = false;
            int removedDishes = this.dishes.RemoveAll(d => d.FoodGroup.Equals(foodGroup));
            if (removedDishes > 0)
            {
                isRemoved = true;
            }

            return isRemoved;
        }
        
        public int CountExpensiveDishesOfFoodGroup(string foodGroup, double priceLevel)
        {
            int countDishes = 0;
            foreach (Dish dish in this.dishes)
            {
                if (dish.FoodGroup.Equals(foodGroup) && dish.Price >= priceLevel)
                {
                    countDishes++;
                }
            }

            return countDishes;
        }



        public void StartCooking()
        {
            this.IsOnABreak = false;
        }



        public Dish DeliverDish(string dishName)
        {
            Dish dish = null;
            foreach (Dish d in this.dishes)
            {
                if (d.Name.Equals(dishName) && !this.IsOnABreak)
                {
                    dish = d;
                }
            }

            return dish;
        }



        public void GiveChefABreak()
        {
            this.IsOnABreak = true;
        }





        public bool IsChefAvailable()
        {
            if (this.IsOnABreak)
            {
                this.IsOnABreak = false;
            }
            else
            {
                this.IsOnABreak = true;
            }

            return this.IsOnABreak;
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Chef {0} from department {1} is able to cook the following dishes:", this.Name, this.Department);
            foreach (Dish dish in this.dishes)
            {
                result.Append(Environment.NewLine);
                result.AppendFormat("{0}", dish);
            }

            return result.ToString();
        }
    }
}
