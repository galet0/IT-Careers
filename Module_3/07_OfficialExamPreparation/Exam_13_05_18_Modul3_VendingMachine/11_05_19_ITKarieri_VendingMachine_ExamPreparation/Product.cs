using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_05_19_ITKarieri_VendingMachine_ExamPreparation
{
    class Product
    {
        private string type;
        private string name;
        private double price;
        private static int ordersCount;

        public Product(string type, string name, double price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }

        public string Type
        {
            get { return type; }
            private set
            {
                //ProduCt
                if (string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value)
                    || !value.Equals(value.ToUpper()))
                {
                    throw new ArgumentException("Invalid type!");
                }

                this.type = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if(string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value)
                    || value.Length < 2)
                {
                    throw new ArgumentException("Invalid name!");
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
                    throw new ArgumentException("Invalid price!");
                }

                this.price = value;
            }
        }

        public static int OrdersCount 
        {
            get { return Product.ordersCount; }
        }

        public static void IncreaseOrdersCount()
        {
            Product.ordersCount++;
        }

        public override string ToString()
        {
            return string.Format("Product with type - {0} and name - {1}",
                this.Type, this.Name);
        }
    }
}
