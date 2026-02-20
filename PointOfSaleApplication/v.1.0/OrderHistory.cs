using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1
{
    internal class OrderHistory
    {
        string name;
        int phoneNumber;
        int age;
        string address;
        string product;
        int quantity;

        public OrderHistory() { }
        public OrderHistory ( string name, int phoneNumber, int age, string address, string product, int quantity) 
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.address = address;
            this.product = product;
            this.quantity = quantity;   
        }

        public void ViewOrderHistory(List<OrderHistory>orderhistory) 
        {
            for(int i = 0; i < orderhistory.Count; i++) 
            {
                Console.WriteLine(" Name : " + orderhistory[i].name + " Phone Number : " + orderhistory[i].phoneNumber + " Age : " + orderhistory[i].age + " Address : " + orderhistory[i].address + " Product : " + orderhistory[i].product + " Quantity : " + orderhistory[i].quantity);
            }
        }
        public void SearchForOrder(List<OrderHistory> orderhistory) 
        {
            Console.WriteLine("Enter the name of Customer : ");
            string name = Console.ReadLine();

            for (int i = 0; i < orderhistory.Count; i++)
            {
                if (name == orderhistory[i].name) 
                {
                    Console.WriteLine(" Name : " + orderhistory[i].name + " Phone Number : " + orderhistory[i].phoneNumber + " Age : " + orderhistory[i].age + " Address : " + orderhistory[i].address + " Product : " + orderhistory[i].product + " Quantity : " + orderhistory[i].quantity);
                }
            }
        }
    }
}