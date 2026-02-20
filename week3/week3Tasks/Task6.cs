using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DepartmentalStore> productsList = new List<DepartmentalStore>();
            while (true) 
            {
                int option = Menu();
                if (option == 1)
                {
                    Console.Write("Enter the name of Product : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the Catogery of Product : ");
                    string category = Console.ReadLine();
                    Console.Write("Enter the Price of Product : ");
                    float price = float.Parse(Console.ReadLine());
                    Console.Write("Enter the Stock Quantity : ");
                    float stockQuantity = float.Parse(Console.ReadLine());
                    Console.Write("Enter the Minimum Quantity : ");
                    float minimumStock = float.Parse(Console.ReadLine());
                    DepartmentalStore products = new DepartmentalStore(name, category, price, stockQuantity, minimumStock);
                    productsList.Add(products);
                }
                if (option == 2) 
                {
                    foreach (DepartmentalStore p in productsList) 
                    {
                        p.ViewProduct(productsList);
                        break;
                    }
                }
                if (option == 3) 
                {
                    foreach(DepartmentalStore p in productsList) 
                    {
                        p.HighestPriceProduct(productsList);
                        break;
                    }
                }
                if (option == 4)
                {
                    foreach(DepartmentalStore p in productsList) 
                    {
                        p.SalesTax(productsList);
                        break;
                    }
                }
                if (option == 5)
                {
                    foreach (DepartmentalStore p in productsList) 
                    {
                        p.OrderProduct(productsList);
                        break;
                    }
                }
            }
        }
        static int Menu() 
        {
            Console.WriteLine("Choose from Menu : ");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Products with highest Unit Price");
            Console.WriteLine("4. View Sales Tax");
            Console.WriteLine("5. Products to be ordered");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class DepartmentalStore
    {
        public string name;
        public string category;
        public float price;
        public float stockQuantity;
        public float minimumStock;
        public float salestax;

        public DepartmentalStore() 
        { }
        public DepartmentalStore(string name , string category , float price , float stockQuantity , float minimumStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.minimumStock = minimumStock;
        }
        
        public void ViewProduct(List<DepartmentalStore>productsList) 
        {
            foreach (DepartmentalStore p in productsList) 
            {
                Console.WriteLine("Name : " + p.name + " Category : " + p.category + " Price : " + p.price );
            }
        }
        public void HighestPriceProduct(List<DepartmentalStore> productsList) 
        {
            float highest = productsList[0].price;
            string hname = " ";
            foreach (DepartmentalStore p in productsList) 
            {
                if (p.price > highest)
                {
                    highest = p.price;
                    hname = p.name;
                }
            }
            Console.WriteLine("The Product with highest Unit Price is : " + hname + " with price "+ highest);
        }
        public void SalesTax(List<DepartmentalStore> productsList) 
        {
            foreach(DepartmentalStore p in productsList) 
            {
                if (p.category == "Grocery" ) 
                {
                    p.salestax = (p.price * 10) / 100;
                }
                else if (p.category == "Fruit")
                {
                    p.salestax = (p.price * 5) / 100;
                }
                else
                {
                    p.salestax = (p.price * 15) / 100;
                }
                Console.WriteLine("The salestax on the product " + p.name + " is : " + p.salestax);
            }
        }
        public void OrderProduct(List<DepartmentalStore> productsList) 
        {
            foreach (DepartmentalStore p in productsList) 
            {
                Console.Write("The products to be ordered are : ");
                if (p.minimumStock >= p.stockQuantity) 
                {
                    Console.WriteLine(p.name);
                }
            }
        }
    }
}