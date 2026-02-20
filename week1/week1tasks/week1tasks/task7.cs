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
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++) 
            {
                Console.Write("Enter numbers : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int largest = numbers[0];
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest) 
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("Largest num is : " + largest);
        }
    }
}
