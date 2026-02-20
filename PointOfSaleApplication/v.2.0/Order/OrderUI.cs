using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v._2._0.Product;

namespace v._2._0.Order
{
    internal class OrderUI
    {
        public void OrderDriver()
        {
            while (true)
            {
                Console.Clear();
                string option = OrderMenu();
                if (option == "1")
                {
                    DisplayAllData();
                }
                else if (option == "2")
                {
                    ViewByCustomerName();
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Choice");
                }
                Console.ReadKey();
            }
        }
        public void DisplayAllData()
        {
            OrderService obj = new OrderService();
            obj.DisplayAllData();
        }
        public void ViewByCustomerName() 
        {
            OrderService obj = new OrderService();
            Console.WriteLine("Enter the name of Customer : ");
            string name = Console.ReadLine();

            obj.SearchByName(name);
        }
        public string OrderMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("***************************");
            Console.WriteLine("*****  ORDER HISTORY  *****");
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. View All Orders");
            Console.WriteLine("2. View Orders by Customer Name");
            Console.WriteLine("3. Back to Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your Choice : ");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}