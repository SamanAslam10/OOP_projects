using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._3._0.Order
{
    internal class OrderService
    {
        private OrderRepoDB repoDB = new OrderRepoDB();
        public OrderService() { }
        public List<OrderModel> GetAllData()
        {
            return repoDB.GetAllOrders();
        }
        public void Save(OrderModel order)
        {
            repoDB.Create(order);
        }
    }
}
