using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v._3._0.Customer;

namespace v._3._0.Order
{
    internal class OrderModel
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public float discount { get; set; }
        public float total { get; set; }

        public OrderModel(int CustomerId , int ProductId , string productName , float price , int quantity , float discount , float total) 
        {
            this.CustomerId = CustomerId;
            this.ProductId = ProductId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.discount = discount;
            this.total = total;
        }
        public override string ToString() 
        {
            return $"{CustomerId},{ProductId},{productName},{price},{quantity},{discount},{total}";
        }
    }
}
