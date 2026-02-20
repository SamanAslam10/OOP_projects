using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Product
    {
        public string name;
        public float purchasePrice;
        public float salePrice;
        public float discount;

        public Product() { }
        public Product(string name , float purchasePrice , float salePrice , float discount) 
        {
            this.name = name;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.discount = discount;
        }
        //Methods
        public void AddProducts(List<Product>productlist) 
        {
            Console.WriteLine("Enter the Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Product Purchase Price : ");
            float purchasePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Sale Price : ");
            float salePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Discount : ");
            float discount = float.Parse(Console.ReadLine());

            this.name = name;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.discount = discount;

            productlist.Add(this);
        }
        public void UpdateProducts(List<Product>products)
        {
            Console.WriteLine("Enter the name of Product you want to update : ");
            string nameU = Console.ReadLine();

            for (int i = 0; i < products.Count; i++) 
            {
                if (products[i].name == nameU) 
                {
                    Console.WriteLine("Enter the Product Name : ");
                    string nameUpdated = Console.ReadLine();
                    Console.WriteLine("Enter the Product Purchase Price : ");
                    float purchasePriceUpdated = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Product Sale Price : ");
                    float salePriceUpdated = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Product Discount : ");
                    float discountUpdated = float.Parse(Console.ReadLine());

                    products[i].name = nameUpdated;
                    products[i].purchasePrice = purchasePriceUpdated;
                    products[i].salePrice = salePriceUpdated;
                    products[i].discount = discountUpdated;
                }
            }
        }
        public void DeleteProducts(List<Product> products)
        {
            Console.WriteLine("Enter the name of Product you want to Remove : ");
            string nameU = Console.ReadLine();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].name == nameU)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
        }
        public void ViewProducts(List<Product>products)
        {
            Console.WriteLine("********************");
            Console.WriteLine("***   PRODUCTS   ***");
            Console.WriteLine("********************");
            foreach (Product p in products) 
            {
                Console.WriteLine(p.name + " " + p.purchasePrice + " " + p.salePrice + " " + p.discount);
            }
        }
    }
}
