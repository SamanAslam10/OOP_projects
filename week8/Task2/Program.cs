using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(1.0 , 1.0 , "red");
            double volume = cylinder.GetVolume();
            Console.WriteLine(volume);
            Circle circle = new Circle();
            double area = circle.getArea();
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
