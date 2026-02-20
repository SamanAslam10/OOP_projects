using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project1
{
    internal class Menu
    {
        public int MainMenu()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*****  SHOP MANAGEMENT SYSTEM  *****");
            Console.WriteLine("************************************");
            Console.WriteLine("1. Product Management");
            Console.WriteLine("2. Customer Management");
            Console.WriteLine("3. Create New Sale(Order)");
            Console.WriteLine("4. View Order History");
            Console.WriteLine("5. Exit");
            Console.WriteLine("-------------------------------------");
            Console.Write("Enter your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public int ProductManagement()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("*****  PRODUCT MANAGEMENT  *****");
            Console.WriteLine("********************************");
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Update Product");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. View All Products");
            Console.WriteLine("5. Back to Main Menu");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public int CustomerManagement()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*****  CUSTOMER MANAGEMENT  *****");
            Console.WriteLine("*********************************");
            Console.WriteLine("1. Add New Customer");
            Console.WriteLine("2. Update Customer");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. View All Customers");
            Console.WriteLine("5. Back to Main Menu");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public int OrderHistory()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*****  ORDER HISTORY  *****");
            Console.WriteLine("***************************");
            Console.WriteLine("1. View All Orders");
            Console.WriteLine("2. View Orders by Customer Name");
            Console.WriteLine("3. Back to Main Menu");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}