using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Customer
    {
        public string name;
        public int phoneNumber;
        public int age;
        public string address;
        public List<Product> productsList = new List<Product>();

        public Customer() { }
        public Customer(string name , int phoneNumber , int age , string address) 
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.address = address;
        }
        
        //Methods
        public void AddNewCustomer(List<Customer>customersList)
        {
            Console.WriteLine("Enter the Customer Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Customer Phone Number : ");
            int phoneNumber  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Customer Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Customer Address : ");
            string address = Console.ReadLine();

            this.name = name;
            this.phoneNumber =phoneNumber;
            this.age = age;
            this.address = address;

            customersList.Add(this);
        }
        public void UpdateCustomer(List<Customer> customersList)
        {
            Console.WriteLine("Enter the name of Customer you want to update : ");
            string nameU = Console.ReadLine();

            for (int i = 0; i < customersList.Count; i++)
            {
                if (customersList[i].name == nameU)
                {
                    Console.WriteLine("Enter the Customer Name : ");
                    string nameUpdated = Console.ReadLine();
                    Console.WriteLine("Enter the Customer Phone Number : ");
                    int phoneNumberUpdated = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Customer Age : ");
                    int ageUpdated = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Customer Address : ");
                    string addressUpdated = Console.ReadLine();

                    customersList[i].name = nameUpdated;
                    customersList[i].phoneNumber = phoneNumberUpdated;
                    customersList[i].age = ageUpdated;
                    customersList[i].address = addressUpdated;
                }
            }
        }
        public void DeleteCustomer(List<Customer> customersList)
        {
            Console.WriteLine("Enter the name of Customer you want to Remove : ");
            string nameU = Console.ReadLine();

            for (int i = 0; i <customersList.Count; i++)
            {
                if (customersList[i].name == nameU)
                {
                    customersList.Remove(customersList[i]);
                    break;
                }
            }
        }
        public void ViewCustomers(List<Customer> customersList)
        {
            Console.WriteLine("********************");
            Console.WriteLine("***   CUSTOMERS   ***");
            Console.WriteLine("********************");
            foreach (Customer c in customersList)
            {
                Console.WriteLine(c.name + " " + c.phoneNumber + " " + c.age + " " + c.address);
            }
        }
        public void GetProducts(Product products) 
        {
            productsList.Add(products);
        }
    }
}
