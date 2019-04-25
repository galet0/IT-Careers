﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _14_04_19_ItKarieri_Constructors_Exercises
{
    class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
    }
}