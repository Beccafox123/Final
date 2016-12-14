﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Passenger
    {
        private string Name;
        private double Weight;
        public static double SumOfWeight = 0;

        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            SumOfWeight += weight;
        }

        public string GetName()
        { return this.Name; }

        public double GetWeight()
        { return this.Weight; }

    }
}
