using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Order
{
    internal class OrderModel
    {
        public string customerName {  get; set; }
        public int age {  get; set; }
        public string phoneNumber {  get; set; }
        public string address {  get; set; }
        public List<OrderItem> items {  get; set; }

        public OrderModel() { } 
        public OrderModel(string customerName ,int age, string phoneNumber , string address) 
        {
            this.customerName = customerName;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
        public OrderModel(string customerName, int age, string phoneNumber, string address , List<OrderItem>items)
        {
            this.customerName = customerName;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.items = items;
        }

       
        public override string ToString()
        {
            return $"{customerName},{age},{phoneNumber},{address}";
        }
    }
}