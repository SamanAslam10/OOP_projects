using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1 = 1;
            string name1 = "Laptop";
            float price1 = 1000;
            Product p1 = new Product(id1 , name1,price1);

            int id2 = 2;
            string name2 = "Mobile";
            float price2 = 2000;
            Product p2 = new Product(id2, name2, price2);

            int id3 = 3;
            string name3 = "Stanley";
            float price3 = 3000;
            Product p3 = new Product(id3, name3, price3);

            List<Product> productsList = new List<Product>();
            productsList.Add(p1);
            productsList.Add(p2);
            productsList.Add(p3);

            while (true) 
            {
                int option = menu();
                if (option == 1) 
                {
                    Console.Write("Enter Product ID : ");
                    int newid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Product name : ");
                    string newname = Console.ReadLine();
                    Console.Write("Enter Product price : ");
                    float newprice = float.Parse(Console.ReadLine());

                    Product newp = new Product(newid, newname, newprice);
                    productsList.Add(newp);
                }
                if (option == 2)
                {
                    for (int i = 0; i < productsList.Count; i++)
                    {
                        Console.WriteLine(productsList[i].ProductID + " " + productsList[i].ProductName + " " + productsList[i].ProductPrice);
                    }
                }
                if (option == 3) 
                {
                    Console.Write("Enter the ID of product you want to search : ");
                    int searchID = int.Parse(Console.ReadLine());

                    for (int i = 0; i < productsList.Count; i++) 
                    {
                        if (productsList[i].ProductID == searchID) 
                        {
                            Console.WriteLine("The Details of the product you searched are : ");
                            Console.WriteLine(productsList[i].ProductName);
                            Console.WriteLine(productsList[i].ProductPrice);
                        }
                    }
                }
            }
        }
        static int menu()
        {
            Console.WriteLine("Choose one option : ");
            Console.WriteLine("1.Add Products");
            Console.WriteLine("2.View All Products");
            Console.WriteLine("3.Search");
         
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class Product 
    {
        public int ProductID;
        public string ProductName;
        public float ProductPrice;

        public Product(int ID, string Name, float Price)
        {
            ProductID = ID;
            ProductName = Name;
            ProductPrice = Price;
        }
    }
}