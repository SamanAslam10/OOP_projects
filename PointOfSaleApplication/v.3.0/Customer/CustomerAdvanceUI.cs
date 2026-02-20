using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v._3._0.Customer
{
    public partial class CustomerAdvanceUI : Form
    {
        CustomerService _service = new CustomerService();
        public CustomerAdvanceUI()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string firstchar = textFirstChar.Text;
            CustomerDataGrid.DataSource = _service.SearchByFirstCharacter(firstchar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = TextName.Text;
            CustomerDataGrid.DataSource = _service.SearchByName(name);
        }

        private void CustomerAdvanceUI_Load(object sender, EventArgs e)
        {

        }

        private void SearchByContact_Click(object sender, EventArgs e)
        {
            string contact = textContact.Text;
            CustomerDataGrid.DataSource = _service.SearchByPhoneNumber(contact);
        }

        private void SearchByAge_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textAge.Text);
            CustomerDataGrid.DataSource = _service.SearchByAge(age);
        }

        private void SearchByAddress_Click(object sender, EventArgs e)
        {
            string address = textAddress.Text;
            CustomerDataGrid.DataSource = _service.SearchByAddress(address);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
