using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Customer
{
    internal class CustomerRepo
    {
        private readonly string file = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\v.2.0\\cuxtomers.txt";

        public CustomerRepo() { }

        public void SaveInFile(CustomerModel customer)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(customer.ToString());
            }
        }
        public void SaveAllDataIntoFile(List<CustomerModel> customerslist)
        {
            File.WriteAllText(file, string.Empty);
            foreach (CustomerModel customer in customerslist)
            {
                SaveInFile(customer);
            }
        }
        public List<CustomerModel> GetCustomersFromFile()
        {
            List<CustomerModel> customersList = new List<CustomerModel>();

            using (StreamReader reader = new StreamReader(file))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string customerName = parts[0];
                    string customerPhoneNumber = parts[1];
                    int customerAge = int.Parse(parts[2]);
                    string customerAddress = parts[3];

                    CustomerModel customer = new CustomerModel(customerName, customerPhoneNumber, customerAge, customerAddress);
                    customersList.Add(customer);
                }
            }
            return customersList;
        }
    }
}
