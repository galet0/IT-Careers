using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_13_05_2018_Modul3_VendingMachine
{
    class Product
    {
        private string type;
        private string name;
        private double price;
        private static int ordersCount;

        //конструктор - приема типа, името и цената на продукта
        public Product(string type, string name, double price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (!value.ToUpper().Equals(value))
                {
                    throw new ArgumentException("Invalid type!");
                }
                this.type = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(value.Length < 2 ||string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                this.price = value;
            }
        }

        /// <summary>
        /// Част от логиката на приложението е да се пази в променлива общия брой 
        /// на всички поръчани продукти. За целта трябва да бъде добавен брояч, 
        /// който да бъде увеличаван с 1 за всеки поръчан продукт.
        ///Важно: Продукт се счита за поръчан, когато бъде изпълнена команда за 
        ///продажба (метод IncreaseOrdersCount(), който се извиква от клас 
        ///VendingMachine в метода SellProduct(string productName)) от съответната вендинг машина.
        /// </summary>
        public static bool OrdersCount { get; }

        public static int IncreaseOrdersCount()
        {
            return Product.ordersCount++;
        }
        
        public override string ToString()
        {
            return $"Product with type - {this.Type} and name - {this.Name}";
        }
    }
}
