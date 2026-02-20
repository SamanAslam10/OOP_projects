using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._3._0.Customer
{
    internal class CustomerService
    {
        private CustomerRepoDB repoDB = new CustomerRepoDB();
        public void AddCustomer(CustomerModel customer)
        {
            repoDB.Create(customer);
        }
        public void UpdateCustomer(CustomerModel customer)
        {
            repoDB.Update(customer);
        }
        public void DeleteCustomer(int id )
        {
            repoDB.Delete(id);
        }
        public List<CustomerModel> GetAllData()
        {
            return repoDB.GetAll();
        }


        // Advance Features 
        public List<CustomerModel> SearchByFirstCharacter(string character)
        {
            List<CustomerModel> customerslist = repoDB.GetAll();
            return customerslist;
        }
        public CustomerModel SearchByPhoneNumber(string phone)
        {
            CustomerModel customer = repoDB.GetByPhone(phone);
            return customer;
        }
        public List<CustomerModel> SearchByAddress(string address)
        {
            List<CustomerModel> customerByAddress = repoDB.GetByAddress(address);
            return customerByAddress;
        }
        public List<CustomerModel> SearchByAge(int age)
        {
            List<CustomerModel> customerByAge = repoDB.GetByAge(age);
            return customerByAge;
        }
        public List<CustomerModel> SearchByName(string name)
        {
            List<CustomerModel> customerByName = repoDB.GetByName(name);
            return customerByName;
        }
    }
}