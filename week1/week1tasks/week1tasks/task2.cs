using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side of the square : ");
            float length = float.Parse(Console.ReadLine());
            float area = length * length;
            Console.WriteLine("The area of square is : " + area);

        }
    }
}
