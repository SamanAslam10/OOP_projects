using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(20,10));
            shapes.Add(new Triangle(20,10));
            shapes.Add(new Circle(20));

            List<ITriangle> list = new List<ITriangle>();   
            list.Add(new Triangle(20,10));

            List<ICircle> list2 = new List<ICircle>();
            list2.Add(new Circle(20)); 

            foreach (Shape shape in shapes) 
            {
                Console.WriteLine(shape.getArea());
                Console.WriteLine(shape.getShapeType());
            }
            foreach (ITriangle shape in list) 
            {
                Console.WriteLine(shape.isRightAngle());
            }
            foreach(ICircle shape in list2)
            {
                Console.WriteLine(shape.getDiameter());
            }
        }
    }
    abstract class Shape
    {
        public abstract double getArea();
        public abstract string getShapeType();
    }
    class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override double getArea()
        {
            return width * height;
        }
        public override string getShapeType()
        {
            return "Rectangle";
        }
    }
    class Triangle : Shape , ITriangle
    {
        private int baseT;
        private int height;
        public Triangle(int baseT, int height)
        {
            this.baseT = baseT;
            this.height = height;
        }
        public override double getArea()
        {
            return (baseT * height)/2;
        }
        public override string getShapeType()
        {
            return "Triangle";
        }
        public bool isRightAngle() 
        {
            return true;
        }
    }
    class Circle : Shape , ICircle
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return radius * radius ;
        }
        public override string getShapeType()
        {
            return "Circle";
        }
        public double getDiameter() 
        {
            return (radius * radius) ;
        }
    }
    interface ICircle 
    {
        double getDiameter();
    }
    interface ITriangle 
    {
        bool isRightAngle();
    }
}
