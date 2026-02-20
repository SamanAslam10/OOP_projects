using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 10;
            float num2 = 10;
            while (true) 
            {
                int option = Menu();
                if (option == 1)
                {
                    Calculator newObj = new Calculator(num1 , num2);
                }
                else if (option == 2) 
                {
                    Console.Write("Enter number1 : ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter number2 : ");
                    num2 = float.Parse(Console.ReadLine());
                    Calculator newObj = new Calculator(num1 , num2);
                }
                else if (option == 3) 
                {
                    Console.WriteLine("Add : " + new Calculator(num1 , num2).Add());
                }
                else if (option == 4)
                {
                    Console.WriteLine("Subtract : " + new Calculator(num1, num2).Subtract());
                }
                else if (option == 5)
                {
                    Console.WriteLine("Multiply : " + new Calculator(num1, num2).Multiply());
                }
                else if (option == 6)
                {
                    Console.WriteLine("Divide : " + new Calculator(num1, num2).Divide());
                }
                else if (option == 7)
                {
                    Console.WriteLine("Modulo : " + new Calculator(num1, num2).Modulo());
                }
                else if (option == 8) 
                {
                    Console.WriteLine("Enter the integer for Square root : ");
                    double integer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Square Root : " + new Calculator().SquareRoot(integer));
                }
                else if (option == 9) 
                {
                    Console.WriteLine("Enter the integer for Exponential Function : ");
                    double integer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Exponential Function : " + new Calculator().ExponentialFunction(integer));
                }
                else if (option == 10) 
                {
                    Console.WriteLine("Enter the number for Natural Logarithm : ");
                    double integer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Natural Logarithm : " + new Calculator().Logarithm(integer));
                }
                else if (option == 11)
                {
                    Console.WriteLine("Enter the number for Trignometric Functions : ");
                    double integer = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Trignometric Function (sin , cos , tan ) ");
                    string trigno = Console.ReadLine();
                    Console.WriteLine("Trignometric Function" + trigno + " : " + new Calculator().TrignometricFunction(integer, trigno));
                }
                else if (option == 12) { }
                {
                    Console.WriteLine("Exiting the Calculator Program");
                    break;
                }
            }
        }
        static int Menu() 
        {
            Console.WriteLine("Choose from Menu : ");
            Console.WriteLine("1. Create a Single Object of Calculator");
            Console.WriteLine("2. Change Values of Attributes");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Subtract");
            Console.WriteLine("5. Multiply");
            Console.WriteLine("6. Divide");
            Console.WriteLine("7. Modulo");
            Console.WriteLine("8. Square Root");
            Console.WriteLine("9. Exponential Fuction");
            Console.WriteLine("10. Logarithm");
            Console.WriteLine("11. Trignometric Functions");
            Console.WriteLine("12. Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class Calculator
    {
        public float number1 ;
        public float number2 ;
        public Calculator() 
        { }
        public Calculator(float number1, float number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public float Add()
        {
            return number1 + number2;
        }
        public float Subtract()
        {
            if (number1 >= number2) 
            {
                return number1 - number2;
            }
            else
            {
                 return number2 - number1;
            }
        }
        public float Multiply()
        {
            return number1 * number2;
        }
        public float Divide()
        {
            if (number2 != 0) 
            {
                return number1 / number2;
            }
            else
            {
                Console.WriteLine("Undefined!");
                return 0;
            }
        }
        public float Modulo()
        {
            return number1 % number2;
        }
        public double SquareRoot(double integer) 
        {
            return Math.Sqrt(integer); 
        }
        public double ExponentialFunction(double integer)
        {
            return Math.Exp(integer);
        }
        public double Logarithm(double integer)
        {
            return Math.Log(integer);
        }
        public double TrignometricFunction(double integer , string trigno) 
        {
            if (trigno == "sin") 
            {
                return Math.Sin(integer);
            }
            else if (trigno == "cos")
            {
                return Math.Cos(integer);
            }
            else if (trigno == "tan")
            {
                return Math.Tan(integer);
            }
            else 
            {
                return 0;
            }
        }
    }
}