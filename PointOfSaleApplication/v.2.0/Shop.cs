using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v._2._0.Product;
using v._2._0.Customer;
using v._2._0.Order;

namespace v._2._0
{
    internal class Shop
    {
        public void Start() 
        {
            while (true)
            {
                Console.Clear();
                string choice = MainMenu();
                if(choice == "1") 
                {
                    ProductUI productUI = new ProductUI();
                    productUI.ProductDriver();
                }
                else if(choice == "2")
                {
                    CustomerUI customerUI = new CustomerUI();
                    customerUI.CustomerDriver();
                }
                else if(choice == "3") 
                {
                    OrderItem orderitem = new OrderItem();
                    orderitem.GetOrder();
                }
                else if(choice == "4") 
                {
                    OrderUI orderUI = new OrderUI();
                    orderUI.OrderDriver();
                }
                else if(choice == "5") 
                {
                    while (true) 
                    {
                        Console.Clear();
                        string choice2 = AdvanceSearch();
                        if (choice2 == "1") 
                        {
                            ProductUI productUI = new ProductUI();
                            productUI.AdvanceSearch();
                        }
                        else if (choice2 == "2") 
                        {
                            CustomerUI customerUI = new CustomerUI();
                            customerUI.AdvanceSearch();
                        }
                        else if (choice2 == "3")
                        {
                            break;
                        }
                    }
                }
                else if (choice == "6")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option!");
                }
            }
        }
        public string MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("************************************");
            Console.WriteLine("*****  SHOP MANAGEMENT SYSTEM  *****");
            Console.WriteLine("************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Product Management");
            Console.WriteLine("2. Customer Management");
            Console.WriteLine("3. Create New Sale(Order)");
            Console.WriteLine("4. View Order History");
            Console.WriteLine("5. Advance Search");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("6. Exit");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your Choice : ");
            string choice = Console.ReadLine();
            return choice;
        }
        public string AdvanceSearch() 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("************************************");
            Console.WriteLine("*****  Advance Search  *****");
            Console.WriteLine("************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose from Below : ");
            Console.WriteLine("1. Advance Search for Products");
            Console.WriteLine("2. Advance Search for Customers");
            Console.WriteLine("3. Back");
            string option = Console.ReadLine();
            return option;
        }
    }
}
