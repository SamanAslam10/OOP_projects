using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v._3._0.Customer;
using v._3._0.Product;

namespace v._3._0.Order
{
    public partial class OrderUI : Form
    {
        OrderService _service = new OrderService();
        private ProductService _productservice;
        private CustomerService _customerservice;
        public OrderUI()
        {
            InitializeComponent();
            _productservice = new ProductService();
            _customerservice = new CustomerService();

            LoadProducts();
            LoadCustomers();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void OrderUI_Load(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }

        private void OrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PriceOrder_Click(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            List<ProductModel> products = _productservice.GetAllData();
            foreach (ProductModel product in products)
            {
                AllProductsGrid.Rows.Add(product.Id, product.name, product.salePrice, product.discount);
            }
        }
        private void LoadCustomers()
        {
            List<CustomerModel> customers = _customerservice.GetAllData();
            foreach (CustomerModel customer in customers)
            {
                CustomerDataGrid.Rows.Add(customer.Id, customer.name, customer.phoneNumber, customer.address);
            }
        }

        private void AllProductsGrid_Click(object sender, EventArgs e)
        {
            ProductTabletoField();
        }
        private void ProductTabletoField()
        {
            int index = AllProductsGrid.CurrentCell.RowIndex;
            if (index > 0)
            {
                string id = AllProductsGrid.Rows[index].Cells[0].Value.ToString();
                string name = AllProductsGrid.Rows[index].Cells[1].Value.ToString();
                string price = AllProductsGrid.Rows[index].Cells[2].Value.ToString();
                string discount = AllProductsGrid.Rows[index].Cells[3].Value.ToString();

                IDText.Text = id;
                ProductText.Text = name;
                PriceText.Text = price;
                DiscountText.Text = discount;
            }
        }
        private void CustomerTableTOField()
        {
            int index = CustomerDataGrid.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string id = CustomerDataGrid.Rows[index].Cells[0].Value.ToString();
                string name = CustomerDataGrid.Rows[index].Cells[1].Value.ToString();

                CustomerIDText.Text = id;
                CustomerNameText.Text = name;
            }

        }
        private void QuantityText_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            float price = float.Parse(PriceText.Text);
            int qty = int.Parse(QuantityText.Text);
            float discount = float.Parse(DiscountText.Text);

            float total = (price * qty) - discount;

            TotalText.Text = total.ToString();
        }

        private void Ad_Click(object sender, EventArgs e)
        {
            AddOrderToTable();
            GrandTotalCalculate();
            ResetFocus();
            SaveOrderToDB();
        }
        private void AddOrderToTable()
        {
            string cid = CustomerIDText.Text;
            string id = IDText.Text;
            string product = ProductText.Text;
            string price = PriceText.Text;
            string quantity = QuantityText.Text;
            string discount = DiscountText.Text;
            string total = TotalText.Text;

            OrderDataGrid.Rows.Add(cid,id, product, price, quantity, discount, total);
        }
        private void GrandTotalCalculate()
        {
            float grandTotal = 0;

            foreach (DataGridViewRow row in OrderDataGrid.Rows)
            {
                if (float.TryParse(row.Cells[6].Value?.ToString(), out float total))
                {
                    grandTotal += total;
                }
            }

            GrandTotalText.Text = grandTotal.ToString();
        }

        private void QuantityText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateTotal();
                AddOrderToTable();
                GrandTotalCalculate();
                SaveOrderToDB();
                ResetFocus();
            }
        }
        private void ResetFocus()
        {
            QuantityText.Text = "0";
            AllProductsGrid.Focus();
        }

        private void AllProductsGrid_KeyUp(object sender, KeyEventArgs e)
        {
            ProductTabletoField();
            if (e.KeyCode == Keys.Enter)
            {
                QuantityText.Focus();
            }
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void AllProductsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QuantityText.Focus();
            }
            e.Handled = true;
            return;
        }

        private void CustomerDataGrid_Click(object sender, EventArgs e)
        {
            CustomerTableTOField();
            AllProductsGrid.Focus();
        }
        private void SaveOrderToDB() 
        {
            _service.Save(GetDataFromOrderTable());
        }
        private OrderModel GetDataFromOrderTable() 
        {
            int index = OrderDataGrid.CurrentCell.RowIndex;
            if (index > 0)
            {
                string customerid = OrderDataGrid.Rows[index].Cells[0].Value.ToString();
                string productid = OrderDataGrid.Rows[index].Cells[1].Value.ToString();
                string product = OrderDataGrid.Rows[index].Cells[2].Value.ToString();
                string price = OrderDataGrid.Rows[index].Cells[3].Value.ToString();
                string quantity = OrderDataGrid.Rows[index].Cells[4].Value.ToString();
                string discount = OrderDataGrid.Rows[index].Cells[5].Value.ToString();
                string total = OrderDataGrid.Rows[index].Cells[6].Value.ToString();

                int c_id = int.Parse(customerid);
                int p_id = int.Parse(productid);
                float fprice = float.Parse(price);
                int iquantity = int.Parse(quantity);
                float fdiscount = float.Parse(discount);
                float ftotal = float.Parse(total);

                OrderModel order = new OrderModel(c_id , p_id , product, fprice, iquantity, fdiscount , ftotal); 
                return order;
            }
            return null ;
        }
        
    }
}
