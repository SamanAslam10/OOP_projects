using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    internal class MountainBike : Bicycle
    {
        public int seatHeight;

        public MountainBike(int seatHeight, int cadence, int speed, int gear) : base(cadence, speed, gear)
        {
            this.seatHeight = seatHeight;
        }
        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
