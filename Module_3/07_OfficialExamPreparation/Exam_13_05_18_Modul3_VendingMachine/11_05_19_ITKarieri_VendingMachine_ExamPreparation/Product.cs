using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_05_19_ITKarieri_VendingMachine_ExamPreparation
{
    class Product
    {
        //полетата на клас Product
        //Всички продукти имат тип, име и цена:
        private string type;
        private string name;
        private double price;
        //статично поле, което отброява колко продукта са продадени
        private static int ordersCount;

        //конструктор за създаване на инстанция на класа 
        //този конструктор трябва да приема типа, името и цената на продукта.
        public Product(string type, string name, double price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }

        //валидации за тип на продукта
        public string Type
        {
            get { return type; }
            private set
            {
                //Продукт-типът трябва да бъде текст създаден само от главни букви, ако не -  Invalid type!
                if (string.IsNullOrEmpty(value)
                    || string.IsNullOrWhiteSpace(value)
                    || value.Equals(value.ToLower()))
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
                //Продукт-името трябва да бъде с дължина над 2 символа - Invalid name!
                if (string.IsNullOrEmpty(value)
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
                //Цената на продукта трябва да положително число, ако не - Invalid price!
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }

                this.price = value;
            }
        }

        //статично свойство на брояча за продадени продукти
        public static int OrdersCount 
        {
            get { return Product.ordersCount; }
        }

        //статичен метод, който използваме в клас VendingMachine
        //за увеличаване броя на продадените продукти
        public static void IncreaseOrdersCount()
        {
            Product.ordersCount++;
        }

        //PrintProductInfo <име> - отпечатва информация за продукт във формат:
        //Product with type - <тип> and name - <име>
        //Тази команда ще получава винаги валидни и съществуващи имена на продукти.
        //За успешна реализация трябва да реализирате ваша версия на ToString() метода за класа Product.

        public override string ToString()
        {
            return string.Format("Product with type - {0} and name - {1}",
                this.Type, this.Name);
        }
    }
}
