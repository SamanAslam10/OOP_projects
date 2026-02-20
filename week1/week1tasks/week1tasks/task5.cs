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
            int num = 0;
            int sum = 0;
            while(num != -1) 
            {
                Console.WriteLine("Enter the num : ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("The sum is : " + sum);
        }
    }
}
