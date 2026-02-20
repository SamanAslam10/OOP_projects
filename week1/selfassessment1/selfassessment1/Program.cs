using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            int n = 10;
            int age;
            Console.Write("Enter age of Lily : ");
            age = int.Parse(Console.ReadLine());

            int priceofMachine;
            Console.Write("Enter price of Machine : ");
            priceofMachine = int.Parse(Console.ReadLine());

            int priceofToys;
            Console.Write("Enter price of toys : ");
            priceofToys = int.Parse(Console.ReadLine());

            for (int a = 1; a < age; a ++ ) 
            {
                if ( a % 2 != 0) 
                {
                    money = money + priceofToys;
                }
                else if ( a % 2 == 0) 
                {
                    money = (money + n) - 1 ;
                    n = n + 10;
                }
            }

            if ( priceofMachine > money)
            {
                int m = priceofMachine - money;
                Console.WriteLine("NO! " + m);
            }
            else if( priceofMachine <= money)
            {
                int m = money - priceofMachine;
                Console.WriteLine("YES! " + m);
            }
        }
    }
}
