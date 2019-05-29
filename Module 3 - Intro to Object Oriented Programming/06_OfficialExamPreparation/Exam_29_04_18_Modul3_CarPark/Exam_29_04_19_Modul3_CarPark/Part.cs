using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_29_04_2018_Modul3_CarPark
{
    class Part
    {
        private string name;
        private double price;

        public Part(string name)
        {
            this.name = name;
            this.price = 25;
        }

        public Part(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name {
            get { return this.name; }
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Invalid part name!");
                }

                this.name = value;
            }
        }

        public double Price {
            get { return this.price; }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return "-> " + this.Name + " - " + string.Format("{0:f2}", this.Price);
        }
    }
}
