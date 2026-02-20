using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                List<Product> products = new List<Product>();
                int option = Menu();
                if (option == 1)
                {
                    Console.WriteLine("Enter the ID of product : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter name of Product : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the Price : ");
                    float price = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Category of Product : ");
                    string category = Console.ReadLine();
                    Console.WriteLine("Enter the Brand Name : ");
                    string Brandname = Console.ReadLine();
                    Console.WriteLine("Enter the Country : ");
                    string Country = Console.ReadLine();
                    Product p = new Product(id ,name,price , category , Brandname , Country);
                    products.Add(p);
                }
                if (option == 2)
                {
                    foreach (Product p in products) 
                    {
                        p.DisplayProduct(products);
                        break;
                    }
                }
                if (option == 3)
                {
                   foreach(Product p in products) 
                    {
                        p.StoreWorth(products);
                        break;
                    }
                }
            }
            
        }
        static int Menu() 
        {
            Console.WriteLine("Choose Option : ");
            Console.WriteLine("1.Add Products ");
            Console.WriteLine("2.Show Products ");
            Console.WriteLine("3.Total Store Worth ");
           
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }

    class Product
    {
        public int ID;
        public string name;
        public float price;
        public string category;
        public string brandname;
        public string country;

        public Product(int id , string name, float price, string category, string brandname , string country)
        {
            ID = id;
            this.name = name;
            this.price = price;
            this.category = category;
            this.brandname = brandname;
            this.country = country;
        }
        public void DisplayProduct(List<Product>products) 
        {
            foreach(Product p in products) 
            {
                Console.WriteLine( p.ID + " " + p.name + " " + p.price + " " + p.category+ " " + p.brandname + " " + p.country);
            }
        }
        public void StoreWorth(List<Product> products) 
        {
            float storeworth = 0;
            foreach (Product p in products) 
            {
                storeworth += p.price;
            }
            Console.WriteLine("The total Store Worth is : " + storeworth);
        }
    }
}
