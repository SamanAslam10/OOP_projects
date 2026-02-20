using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using v._2._0.Product;

namespace v._2._0.Customer
{
    internal class CustomerService
    {
        private CustomerRepoDB repoDB = new CustomerRepoDB();
        private CustomerRepo repo = new CustomerRepo();

        public void AddCustomer(CustomerModel customer) 
        {
            bool addCheck = repoDB.Create(customer);
            if (addCheck == true) 
            {
                Console.WriteLine("Customer Added Successfully!");
            }
            else 
            {
                Console.WriteLine("Couldm't Add Customer");
            }
        }
        public void UpdateCustomer(CustomerModel customer) 
        {
            bool updateCheck = repoDB.Update(customer);
            if (updateCheck == true) 
            {
                Console.WriteLine("Customer Updated Successfully!");
            }
            else 
            {
                Console.WriteLine("Couldn't Update Customer!");
            }
        }
        public void DeleteCustomer(string name) 
        {
            bool deletecheck = repoDB.Delete(name);
            if (deletecheck == true)
            {
                Console.WriteLine("Customer Delt Successfully!");
            }
            else 
            {
                Console.WriteLine("Couldn't Delete Customer!");
            }
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