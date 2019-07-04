using System;
using System.Collections.Generic;
using System.Text;

namespace Train
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }

        public int Number { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Cars { get; private set; }

        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
