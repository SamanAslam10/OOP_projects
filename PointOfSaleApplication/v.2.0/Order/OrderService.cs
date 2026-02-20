using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v._2._0.Product;

namespace v._2._0.Order
{
    internal class OrderService
    {
        private OrderRepoDB repoDB = new OrderRepoDB();
        public OrderService(){}
        public List<OrderModel> GetAllData()
        {
            return repoDB.GetAllOrders();
        }
        public void Save(OrderModel order , List<OrderItem>orderItems)
        {
            repoDB.Create(order,orderItems);
        }
        public void SearchByName(string name)
        {
            List<OrderModel> orderslist = new List<OrderModel>();
            orderslist = repoDB.GetAllOrders();
            foreach (OrderModel order in orderslist) 
            {
                if (order.customerName == name)
                {
                    Console.WriteLine(order.ToString());
                    foreach (OrderItem items in order.items)
                    {
                        Console.WriteLine(items.ToString());
                    }
                    Console.ReadKey();
                }
            }
        }
        public void DisplayAllData()
        {
            List<OrderModel> orderslist = new  List<OrderModel>();
            orderslist = repoDB.GetAllOrders();
            foreach (OrderModel order in orderslist)
            {
                Console.WriteLine(order.ToString());
                foreach (OrderItem item in order.items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey();
        }

    }
}