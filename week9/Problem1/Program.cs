using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Cylinder cylinder2 = new Cylinder(2.5 , 3.4);
            Cylinder cylinder3 = new Cylinder(4);

            cylinder.setHeight(3.4);
            double volume = cylinder.GetVolume();
        }
    }
}
