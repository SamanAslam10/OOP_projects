using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer
    {
        public string name;
        public string address;
        public int contact;
        public List<Product> products = new List<Product>();

        public Customer(string name , string address , int contact) 
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
        }
        public List<Product> getAllProducts()
        {
            return products;
        }
        public void AddProduct(Product product) 
        {
            products.Add(product);
        }
        public float CalculateBill() 
        {
            float Bill = 0;
            for (int i = 0; i < products.Count; i++) 
            {
                Bill += products[i].price;
            }
            return Bill;
        }
    }
}
