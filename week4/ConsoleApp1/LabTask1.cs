using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                int option = Menu();
                Console.WriteLine(option);
                if (option == 1) 
                {

                }
                else if (option == 2) 
                { }
                else if (option == 3) 
                { }
                else if (option == 4) 
                { }
                else if (option == 5)
                {
                    Console.WriteLine("Exiting!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option!");
                }
            }
        }
        static int Menu() 
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Add a Book");
            Console.WriteLine("2.Search by Title");
            Console.WriteLine("3.Search by ISBN");
            Console.WriteLine("4.Update no.of Copies");
            Console.WriteLine("5.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void AddBook() { }
    }   
}
