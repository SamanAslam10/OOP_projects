using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    internal class Bicycle
    {
        public int cadence;
        public int gear;
        public int speed;

        public Bicycle() { }
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setCadence(in int cadence)
        {
            this.cadence = cadence;
        }
        public void setGear(in int gear)
        {
            this.gear = gear;
        }
        public void applyBrake(int decrement)
        {
            this.speed -= decrement;
        }
        public void speedUp(int increment)
        {
            this.speed += increment;
        }
    }
}
