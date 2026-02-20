using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Cylinder : Circle
    {
        public double height;

        public Cylinder() { }
        public Cylinder(double radius) : base(radius) { }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            double volume = (4 / 3) * (3.14) * (radius * radius * radius);
            return volume;
        }
    }
}
