using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Elevator
    {
        private double MaxWeight;

        public Passenger[] Occupants;

        public Elevator(int maxOccupants,double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight= maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;

        }


        public double GetCurrentWeight()
        {
            return Passenger.SumOfWeight;
        }

        public bool isOverMaxCapacity(double CurrentWeight)
        {
            if (CurrentWeight > MaxWeight)
            { return true; }
            else
            { return false; }
        }

    }
}
