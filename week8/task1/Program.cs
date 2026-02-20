using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike bike = new MountainBike(50,20,30,10);
            bike.setSeatHeight(60);
            Bicycle bicycle = new Bicycle();
            bicycle.setCadence(30);
            bicycle.setGear(30);
            bicycle.applyBrake(30);
            bicycle.speedUp(20);
        }
    }
}