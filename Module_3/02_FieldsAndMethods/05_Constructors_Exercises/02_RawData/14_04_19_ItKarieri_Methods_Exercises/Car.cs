using System;
using System.Collections.Generic;
using System.Text;

namespace _14_04_19_ItKarieri_Constructors_Exercises
{
    class Car
    {
        //модела, двигателя, товара и колекция от точно 4 гуми
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = new List<Tire>();
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public List<Tire> Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public void AddTire(Tire tire)
        {
            this.tires.Add(tire);
        }
    }
}
