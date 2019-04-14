using System;
using System.Collections.Generic;
using System.Text;

namespace _14_04_19_ItKarieri_Constructors_Exercises
{
    class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
