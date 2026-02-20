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
    public partial class CustomerUI : Form
    {
        CustomerService _service = new CustomerService();

        public CustomerUI()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void CustomerName_Click(object sender, EventArgs e)
        {

        }
        private void LoadCustomers()
        {
            List<CustomerModel> customers = _service.GetAllData();
            foreach (CustomerModel customer in customers)
            {
                CustomerDataGrid.Rows.Add(customer.Id,customer.name , customer.age , customer.phoneNumber , customer.address);
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (NameText.Text == null || ageText.Text == null || ContactText.Text == null || AddressText.Text == null)
            {
                return;
            }
            else
            {
                int id = int.Parse(Idtext.Text);
                string name = NameText.Text;
                int age = int.Parse(ageText.Text);
                string contact = ContactText.Text;
                string address = AddressText.Text;

                CustomerModel customer = new CustomerModel(id, name, contact, age, address);
                _service.AddCustomer(customer);

                LoadCustomers();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (NameText.Text == null || ageText.Text == null || ContactText.Text == null || AddressText.Text == null)
            {
                return;
            }
            else
            {
                int id = int.Parse(Idtext.Text);
                string name = NameText.Text;
                int age = int.Parse(ageText.Text);
                string contact = ContactText.Text;
                string address = AddressText.Text;

                CustomerModel customer = new CustomerModel(id, name, contact, age, address);
                _service.UpdateCustomer(customer);

                LoadCustomers();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Idtext.Text);
            _service.DeleteCustomer(id);

            LoadCustomers();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormHelper.PopulateScreen(new MainMenu());
        }

        private void ageText_TextChanged(object sender, EventArgs e)
        {
        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
        }

        private void ContactText_TextChanged(object sender, EventArgs e)
        {
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {

        }

        private void Idtext_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                NameText.Focus();
            }
        }

        private void NameText_Enter(object sender, EventArgs e)
        {
        }

        private void ageText_Enter(object sender, EventArgs e)
        {
        }

        private void ContactText_Enter(object sender, EventArgs e)
        {
        }

        private void AddressText_Enter(object sender, EventArgs e)
        {

        }

        private void NameText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ageText.Focus();
            }
        }

        private void ageText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ContactText.Focus();
            }
        }

        private void ContactText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                AddressText.Focus();
            }
        }

        private void AddressText_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                Add.Focus();
            }
        }
    }
}