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
                List<Customer> customersList = new List<Customer>();
                int option = Menu();
                if (option == 1)
                {
                    Customer customer = CustomerAdd();
                    customersList.Add(customer);
                    while (true) 
                    {
                        Console.WriteLine("Do you want to add Products : ");
                        string choice = Console.ReadLine();
                        if (choice == "yes")
                        {
                            Product p = ProductAdd();
                            customer.AddProduct(p);
                        }
                        else 
                        {
                            break;
                        }
                    }
                }
                else if (option == 2)
                {
                    for (int i = 0; i <customersList.Count; i ++) 
                    {
                        Console.WriteLine(customersList[i].name + " " + customersList[i].address + " " + customersList[i].contact);
                    }
                }
                else if (option == 3)
                {
                    for(int i = 0; i < customersList.Count; i ++) 
                    {
                        Console.WriteLine(customersList[i].name + " " + customersList[i].products.Count);
                    }
                }
                else if (option == 4)
                {
                    foreach (Customer c in customersList) 
                    {
                       float bill = c.CalculateBill();
                        Console.WriteLine(c.name + " " + bill);
                        break;
                    }
                    
                }
                else if (option == 5)
                {
                    Console.WriteLine("Exiting!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option");
                }
            }
        }

        static int Menu() 
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Login and Buy Products ");
            Console.WriteLine("2.Display all Customers");
            Console.WriteLine("3.Display Customer with Product Count");
            Console.WriteLine("4.Calculate Bill");
            Console.WriteLine("5.Exit");

            int option = int.Parse(Console.ReadLine());
            return option;

        }
        static Customer CustomerAdd() 
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Adress : ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Contact : ");
            int contact = int.Parse(Console.ReadLine());

            Customer custobj = new Customer(name, address ,contact);
            return custobj;
        }
        static Product ProductAdd() 
        {
            Console.WriteLine("Enter the name of Product : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the category of Product : ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter the price of Product : ");
            float price = float.Parse(Console.ReadLine());

            Product p = new Product(name, category, price);
            return p;
        }
    }
}
