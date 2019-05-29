using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Product
    {
        private string name;
        private double price;
        private bool isOnPromotion;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product(string name, double price, bool isOnPromotion)
        {
            this.Name = name;
            this.IsOnPromotion = isOnPromotion;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid product name!");
                }

                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                if (this.IsOnPromotion)
                {
                    this.price = value * 0.8;
                }
                else
                {
                    this.price = value;
                }
                
            }
        }

        public bool IsOnPromotion
        {
            get { return this.isOnPromotion; }
            private set
            {
                this.isOnPromotion = value;
            }
        }

        public override string ToString()
        {
            //Product -> <име> with price <цена>. On promotion <YES/NO>
            if (this.IsOnPromotion)
            {
                return $"Product -> {this.Name} with price {this.Price:f2}. On promotion: YES";
            }
            else
            {
                return $"Product -> {this.Name} with price {this.Price:f2}. On promotion: NO";
            }
            
        }
    }
}
