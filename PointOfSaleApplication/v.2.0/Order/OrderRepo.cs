using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Order
{
    internal class OrderRepo
    {
        private readonly string file = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\v.2.0\\orders.txt";

        public void Save(OrderModel order) 
        {
            using (StreamWriter writer = new StreamWriter(file , true)) 
            {
                string customerdata = $"customer,{order.customerName},{order.age},{order.phoneNumber},{order.address}";
                writer.WriteLine(customerdata);
                foreach (OrderItem items in order.items) 
                {
                    string line = $"item,{items.product},{items.quantity},{items.salePrice},{items.quantity * items.salePrice}";
                    writer.WriteLine(line);
                }
            }
        }
        public List<OrderModel> GetAllOrders() 
        {
            List<OrderModel> orders = new List<OrderModel>();

            using (StreamReader reader = new StreamReader(file)) 
            {
                string line = "";
                OrderModel temporder = null;
                while ((line = reader.ReadLine()) != null) 
                {
                    if (line.StartsWith("customer"))
                    {
                        string[] parts = line.Split(',');
                        string name = parts[1];
                        int age = int.Parse(parts[2]);
                        string phoneNumber = parts[3];
                        string address = parts[4];
                        temporder = new OrderModel(name, age, phoneNumber, address);
                        orders.Add(temporder);
                    }
                    else if (line.StartsWith("item"))
                    {
                        string[] parts = line.Split(',');
                        string product = parts[1];
                        int quantity = int.Parse(parts[2]);
                        float salePrice = float.Parse(parts[3]);
                        OrderItem orderitem = new OrderItem(product, quantity, salePrice);
                    }
                }
            }
            return orders;
        }
    }
}
