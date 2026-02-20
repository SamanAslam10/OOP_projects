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
            Console.WriteLine("Enter the number : ");
            float num = float.Parse(Console.ReadLine());
            if (num <= 50) 
            {
                Console.WriteLine("You are Failed!");
            }
            else if(num > 50) 
            {
                Console.WriteLine("You are Passed!");
            }
        }
    }
}
