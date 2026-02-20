using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v._3._0.Order
{
    public partial class OrderHistory : Form
    {
        OrderService _service;
        public OrderHistory()
        {
            _service = new OrderService();
            InitializeComponent();
            LoadOrders();
        }

        private void OrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            List<OrderModel> orders = _service.GetAllData();
            foreach (OrderModel order in orders)
            {
                OrderHistoryDataGrid.Rows.Add(order.CustomerId, order.ProductId, order.productName, order.price, order.quantity, order.discount, order.total);
            }
        }

        private void AddOrderLabel_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new Order.OrderUI());
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
