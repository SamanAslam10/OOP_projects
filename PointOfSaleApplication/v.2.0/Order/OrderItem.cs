using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Order
{
    internal class OrderItem
    {
        OrderService orderService = new OrderService();
        public string product {get; set; }
        public int quantity { get; set; }
        public float salePrice { get; set; }
        public OrderItem(){ }
        public OrderItem(string product, int quantity, float salePrice)
        {
            this.product = product;
            this.quantity = quantity;
            this.salePrice = salePrice;
        }
        public List<OrderModel> GetOrder() 
        {
            List<OrderModel>orderslist = new List<OrderModel>();
            Console.Clear();
            Console.WriteLine("===== PLACE NEW ORDER =====");

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter Customer Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            OrderModel order = new OrderModel(customerName, age, phone, address);

            List<OrderItem> items = new List<OrderItem>();

            Console.WriteLine("How many items do you want to order?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($" Item #{i + 1} ");
                Console.Write("Enter Product Name: ");
                string product = Console.ReadLine();
                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter Sale Price: ");
                float price = float.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(product, quantity, price);
                items.Add(item);
            }
            OrderModel orderDB = new OrderModel(customerName, age, phone, address,items);
            orderslist.Add(orderDB);
            orderService.Save(order , items);
            return orderslist;
        }
        public override string ToString()
        {
            return $"{product},{quantity},{salePrice}";
        }
    }
}
