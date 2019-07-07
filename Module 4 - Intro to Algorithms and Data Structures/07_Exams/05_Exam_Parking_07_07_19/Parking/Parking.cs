using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parking
    {
        private int count;
        private Car head;
        private Car tail;

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public Car Head { get { return this.head; } private set { this.head = value; } }

        public Car Tail { get { return this.tail; } private set { this.tail = value; } }

        public Parking() { }

        public void AddCar(string carNumber)
        {
            Car car = new Car(carNumber);

            if (this.Count == 0)
            {
                this.Head = car;
                this.Tail = car;
            }
            else
            {
                this.Tail.Next = car;
                this.Tail = car;
            }

            this.Count++;
        }

        public void AddFancyCar(string carNumber)
        {
            Car car = new Car(carNumber);

            if (this.Count == 0)
            {
                this.Head = car;
                this.Tail = car;
            }
            else
            {
                car.Next = this.Head;
                this.Head = car;
            }
            this.Count++;
        }



        public Car CheckCarIsPresent(string carNumber)
        {
            Car car = this.Head;

            while (car != null)
            {
                if (car.CarNumber.Equals(carNumber))
                {
                    return car;
                }

                car = car.Next;
            }

            return null;
        }

        public bool ReleaseCar(string carNumber)
        {
            Car currentCar = this.Head;
            int index = 0;
            bool isReleased = false;

            while (currentCar != null)
            {
                if (currentCar.CarNumber.Equals(carNumber))
                {
                    isReleased = this.ReleaseCar(index);
                }

                index++;
                currentCar = currentCar.Next;
            }

            return isReleased;
        }

        public bool ReleaseCar(int index)
        {
            bool isReleased = false;
            Car previousCar = null;
            Car currentCar = this.Head;
            int currentIndex = 0;

            while (currentCar != null)
            {
                if (currentIndex == index)
                {
                    isReleased = true;
                    this.Count--;
                    if(previousCar != null)
                    {
                        previousCar.Next = currentCar.Next;                        
                    }
                    if (previousCar == null)
                    {
                        this.Head = this.Head.Next;
                    }
                    if(currentCar.Next == null)
                    {
                        this.Tail = previousCar;
                    }
                }

                currentIndex++;
                previousCar = currentCar;
                currentCar = currentCar.Next;
                /*if (currentIndex == index)
                {
                    if (previousCar != null)
                    {
                        //prev.next = one cuur.next = two
                        previousCar.Next = currentCar.Next;
                    }
                    else
                    {
                        this.head = currentCar.Next;
                    }

                    if (currentCar.Next == null)
                    {
                        this.tail = previousCar;
                    }
                    count--;
                    isReleased = true;
                }
                else
                {
                    //prev = zero
                    previousCar = currentCar;
                    //curr = one
                    currentCar = currentCar.Next;
                    //currIndex = 1
                    currentIndex++;
                }*/
            }

            return isReleased;
        }

        public StringBuilder ParkingInformation()
        {
            Car currentCar = this.Head;
            StringBuilder sb = new StringBuilder();

            while (currentCar != null)
            {
                sb.Append(currentCar);
                sb.Append(Environment.NewLine);
                currentCar = currentCar.Next;
            }

            return sb;
        }
    }
}
