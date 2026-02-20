using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v._3._0.Product
{
    public partial class ProductUI : Form
    {
        ProductService _service = new ProductService();
        public ProductUI()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void ProductMenu_Load(object sender, EventArgs e)
        {
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadProducts()
        {
            List<ProductModel> products = _service.GetAllData();
            foreach (ProductModel product in products)
            {
                ProductDataGrid.Rows.Add(product.Id, product.name,product.purchasePrice, product.salePrice, product.discount);
            }
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null || PurchasePriceTextBox.Text == null || SalePriceTextBox.Text == null || DiscountTextBox.Text == null) return;
            else
            {
                int id = int.Parse(IDtext.Text);
                string name = nameTextBox.Text;
                float purchasePrice = float.Parse(PurchasePriceTextBox.Text);
                float salePrice = float.Parse(SalePriceTextBox.Text);
                int discount = int.Parse(DiscountTextBox.Text);

                ProductModel product = new ProductModel(id, name, purchasePrice, salePrice, discount);
                _service.AddProduct(product);

                LoadProducts();
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null) return;
            else
            {
                int id = int.Parse(IDtext.Text);
                string name = nameTextBox.Text;
                float purchasePrice = float.Parse(PurchasePriceTextBox.Text);
                float salePrice = float.Parse(SalePriceTextBox.Text);
                int discount = int.Parse(DiscountTextBox.Text);

                ProductModel product = new ProductModel(id, name, purchasePrice, salePrice, discount);
                _service.UpdateProduct(product);

                LoadProducts();
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDtext.Text);
            _service.DeleteProduct(id);

            LoadProducts();
        }

        private void ViewAllProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PurchasePriceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SalePriceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void IDtext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameTextBox.Focus();
            }
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PurchasePriceTextBox.Focus();
            }
        }

        private void PurchasePriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SalePriceTextBox.Focus();
            }
        }

        private void SalePriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DiscountTextBox.Focus();
            }
        }

        private void DiscountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                AddProduct.Focus();
            }
        }
    }
}