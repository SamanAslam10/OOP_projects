using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Circle
    {
        public double radius;
        public string color;

        public Circle() { }
        public Circle(double radius) 
        {
            this.radius = radius; 
        }
        public Circle(double radius, string color) 
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetRadius() 
        {
            return radius;
        }
        public void SetRadius(double radius) 
        {
            this.radius = radius;
        }
        public string GetColor() 
        {
            return color;
        }
        public void SetColor(string color) 
        {
            this.color = color;
        }
        public double getArea() 
        {
            double area = (3.14)*(radius * radius);
            return area;
        }
        public override string ToString() 
        {
            return $"Circle[radius = {radius} , color =] {color}";
        }
    }
}
