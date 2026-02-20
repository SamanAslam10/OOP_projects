using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation ( + , - , * , / ) : ");
            char operation = char.Parse(Console.ReadLine());

            Calculator solution = new Calculator( num1 , num2);
            if (operation == '+' )
            {
                solution.Addition();
            }
            if (operation == '-')
            {
                solution.Subtraction();
            }
            if (operation == '*')
            {
                solution.Multiplication();
            }
            if (operation == '/')
            {
                solution.Division();
            }
        }
    }

    class Calculator 
    {
        public float number1;
        public float number2;
        public float result;
        public Calculator(float num1 , float num2 ) 
        {
            number1 = num1;
            number2 = num2;
        }

         public void Addition() 
        {
            result = number1 + number2;
            Console.WriteLine(result);
        }
        public void Subtraction()
        {
            result = number1 - number2;
            Console.WriteLine(result);
        }
        public void Multiplication()
        {
            result = number1 * number2;
            Console.WriteLine(result);
        }
        public void Division()
        {
            result = number1 / number2;
            Console.WriteLine(result);
        }

    }
}
