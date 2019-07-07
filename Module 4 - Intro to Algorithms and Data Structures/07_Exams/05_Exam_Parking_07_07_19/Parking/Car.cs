using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Car
    {
        private string carNumber;
        private Car next;

        public Car(string carNumber)
        {
            this.CarNumber = carNumber;                 
        }

        public string CarNumber
        {
            get { return this.carNumber; }
            set { this.carNumber = value; }
        }

        public Car Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public override string ToString()
        {
            return $"Car: {this.CarNumber}";
        }
    }
}
