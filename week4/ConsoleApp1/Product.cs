using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public string name;
        public string category;
        public float price;

        public Product(string name, string category, float price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public double CalculateTax()
        {
            double tax = 0;
            return tax = price * 0.5;
        }
    }
}
