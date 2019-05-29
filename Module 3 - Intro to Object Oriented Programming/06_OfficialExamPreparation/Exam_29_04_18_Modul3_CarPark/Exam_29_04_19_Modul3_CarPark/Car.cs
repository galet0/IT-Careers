using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_29_04_2018_Modul3_CarPark
{
    class Car
    {
        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts;
        private double fuel;
        private static int carCount;

        public Car(string manufacturer, string model, double loadCapacity)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.LoadCapacity = loadCapacity;
            this.parts = new List<Part>();
            this.fuel = 100;
            Car.carCount += 1;
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid manufacturer name!");
                }

                this.manufacturer = value;
            }
        }

        public double LoadCapacity
        {
            get { return this.loadCapacity; }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Invalid load capacity!");
                }

                this.loadCapacity = value;

            }
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid model name!");
                }

                this.model = value;
            }
        }

        public double GetCarPrice()
        {
            return this.Parts.Sum(p => p.Price);
        }

        public IReadOnlyCollection<Part> Parts
        {
            get { return this.parts; }

        }

        public double Fuel
        {
            get { return this.fuel; }
            private set
            {
                this.fuel = value;
            }
        }

        public void AddPart(Part part)
        {
            this.parts.Add(part);
        }

        public void AddMultipleParts(List<Part> parts)
        {
            this.parts.AddRange(parts);
        }

        public void RemovePartByName(string partName)
        {
            for (int i = 0; i < this.Parts.Count; i++)
            {
                if (this.parts[i].Name.Equals(partName))
                {
                    this.parts.Remove(parts[i]);
                }
            }

        }

        public List<Part> GetPartsWithPriceAbove(double price)
        {
            List<Part> partsWithPriceAbove = new List<Part>();
            foreach (Part part in parts)
            {
                if (price < part.Price)
                {
                    partsWithPriceAbove.Add(part);
                }
            }

            return partsWithPriceAbove;
        }

        public Part GetMostExpensivePart()
        {
            double maxPrice = this.parts.Max(p => p.Price);
            foreach (Part part in parts)
            {
                if (maxPrice == part.Price)
                {
                    return part;
                }
            }

            return null;
        }

        public bool ContainsPart(string partName)
        {
            bool contains = false;
            foreach (Part part in parts)
            {
                if (partName.Equals(part.Name))
                {
                    contains = true;
                }
            }

            return contains;
        }

        public void Drive(double distance)
        {
            if(this.Fuel - this.LoadCapacity * 0.2 * distance < 0)
            {
                throw new ArgumentException("Drive not possible!");
            }
            else
            {
                this.Fuel -= this.LoadCapacity * 0.2 * distance;
            }
            
        }

        public static int OrdersCount
        {
            get { return Car.carCount; }
        }

        public override string ToString()
        {
            //CLK made by Mercedes
            //Available parts:
            //-> carSeat - 100.00
            //With total price of: 100.00 lv.
            string result = string.Format(
                this.Model.ToUpper() + " made by " + this.Manufacturer
                + "\n" + "Available parts:"
                + "\n");
            foreach (Part part in parts)
            {
                result += part + "\n";
            }

            result += "With total price of: " + string.Format("{0:f2} lv.", this.GetCarPrice());
            return result;
        }

    }
}
