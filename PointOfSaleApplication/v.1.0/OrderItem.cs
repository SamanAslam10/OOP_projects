using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1
{
    internal class OrderItem
    {
        List<Customer> customerslist = new List<Customer>();
        List<Product> productslist = new List<Product>();
        public string orderProduct;
        public int orderQuantity;
        List<OrderItem>orderslist = new List<OrderItem>();
        
        public OrderItem(string name , int qunatity) 
        {
            orderProduct = name;
            orderQuantity = qunatity;
        }
        public OrderItem(List<Customer> customerslist, List<Product> productslist)
        { 
            this.customerslist = customerslist;
            this.productslist = productslist;
        }
        public bool CheckCustomer( string name) 
        {
            foreach (Customer c in customerslist) 
            {
                if (name == c.name)
                {
                    Console.WriteLine(c.name + " " + c.phoneNumber + " " + c.age + " " + c.address);
                    return true;
                }
            }
            return false;
        }
        public List<OrderItem> OrderProducts() 
        {
            Console.Write("Enter the name of Product you want to Order : ");
            string nameP = Console.ReadLine();
            
            bool check = false ;
            foreach (Product p in productslist) 
            {
                if (nameP == p.name) 
                {
                    Console.WriteLine("Product name : " + p.name + " Sale Price : " + p.salePrice + " Purchase Price : " + p.purchasePrice + " Discount : " + p.discount);
                    Console.WriteLine("Enter the Quantity : ");
                    int qunatity = int.Parse(Console.ReadLine());
                    
                    OrderItem orderItem = new OrderItem(nameP , qunatity);
                    orderslist.Add(orderItem);
                    check = true;
                    break;
                }
            }
            if (check == false) 
            {
                Console.WriteLine("This Product doesn't Exist");
            }
            return orderslist;
        }
    }
}
