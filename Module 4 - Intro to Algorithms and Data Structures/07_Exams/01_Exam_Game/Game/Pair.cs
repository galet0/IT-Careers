using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }

        public Pair(int first, int last)
        {
            //Add code
            this.First = first;
            this.Last = last;
        }

        public int Difference()
        {
            //Add code
            return Math.Abs(this.First - this.Last);
        }

        public override string ToString()
        {
            //Add code
            return string.Format("({0}, {1})", this.First, this.Last);
        }
    }
}
