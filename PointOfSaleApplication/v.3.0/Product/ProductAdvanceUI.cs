using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v._3._0.Customer;

namespace v._3._0.Product
{
    public partial class ProductAdvanceUI : Form
    {
        ProductService _service = new ProductService();
        public ProductAdvanceUI()
        {
            InitializeComponent();
        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            ProductDataGrid.DataSource = _service.SearchByName(name);
        }

        private void SearchByPrice_Click(object sender, EventArgs e)
        {
            float price = float.Parse(TextBoxPrice.Text);
            ProductDataGrid.DataSource = _service.SearchAllProductsbyPrice(price);
        }

        private void SearchWithinPrice_Click(object sender, EventArgs e)
        {
            float start = float.Parse(textBoxPriceStart.Text);
            float end = float.Parse(textBoxPriceEnd.Text);
            ProductDataGrid.DataSource = _service.SearchByPriceRange(start, end);
        }

        private void SearchByPriceDifference_Click(object sender, EventArgs e)
        {
            float price = float.Parse(textBoxPriceDifference.Text);
            ProductDataGrid.DataSource = _service.SearchByPriceDifference(price);
        }

        private void SearchBySubString_Click(object sender, EventArgs e)
        {
            string substring = textBoxSubString.Text;
            ProductDataGrid.DataSource = _service.SearchBySubString(substring);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }
    }
}
