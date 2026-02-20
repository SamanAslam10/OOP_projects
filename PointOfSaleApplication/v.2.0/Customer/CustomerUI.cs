using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v._2._0.Product;

namespace v._2._0.Customer
{
    internal class CustomerUI
    {
        CustomerService service = new CustomerService();
        public void CustomerDriver()
        {
            while (true)
            {
                Console.Clear();
                string choice = CustomerMenu();
                if (choice == "1")
                {
                    CustomerModel customer = TakeInput();
                    service.AddCustomer(customer);
                }
                else if (choice == "2")
                {
                    UpdateCustomer();
                }
                else if (choice == "3")
                {
                    DeleteCustomer();
                }
                else if (choice == "4")
                {
                    DisplayAllData();
                    Console.ReadKey();
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option!");
                }
            }
        }
        public string CustomerMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*********************************");
            Console.WriteLine("*****  CUSTOMER MANAGEMENT  *****");
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Add New Customer");
            Console.WriteLine("2. Update Customer");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. View All Customers");
            Console.WriteLine("5. Back to Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your Choice : ");
            string choice = Console.ReadLine();
            return choice;
        }
        public CustomerModel TakeInput()
        {
            Console.WriteLine("Enter the Customer Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Customer Phone Number : ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Customer Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Customer Address : ");
            string address = Console.ReadLine();

            CustomerModel customer = new CustomerModel(name, phoneNumber, age, address);
            return customer;
        }
        public void UpdateCustomer()
        {
            Console.WriteLine("Enter the Customer Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Customer Phone Number : ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Customer Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Customer Address : ");
            string address = Console.ReadLine();

            CustomerModel customer = new CustomerModel(name , phoneNumber , age , address);
            service.UpdateCustomer(customer);
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("Enter the Customer Name : ");
            string name = Console.ReadLine();


            service.DeleteCustomer(name);
        }
        public void DisplayAllData()
        {
            foreach (CustomerModel c in service.GetAllData())
            {
                Console.WriteLine(c.ToString());
            }
        }
        public void AdvanceSearch() 
        {
            while (true) 
            {
                Console.Clear();
                string option = AdvanceMenu();
                if(option == "1") 
                {
                    SearchByName();
                }
                else if(option == "2") 
                {
                    SearchByFirstCharacter();
                }
                else if(option == "3") 
                {
                    SearchByPhoneNumber();
                }
                else if( option == "4") 
                {
                    SearchByAddress();
                }
                else if(option == "5") 
                {
                    SearchByAge();
                }
                else if(option == "6") 
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option!");
                }
                Console.ReadKey();
            }
        }
        public void SearchByName() 
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();

            List<CustomerModel>customer = service.SearchByName(name);
            foreach (CustomerModel c in customer)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public void SearchByFirstCharacter() 
        {
            Console.WriteLine("Enter the First Character : ");
            string character = Console.ReadLine();

            List<CustomerModel> customers = service.SearchByFirstCharacter(character);
            foreach(CustomerModel customer in customers) 
            {
                Console.WriteLine(customer.ToString());
            }
        }
        public void SearchByPhoneNumber()
        {
            Console.WriteLine("Enter PhoneNumber : ");
            string phone = Console.ReadLine();

            CustomerModel customer = service.SearchByPhoneNumber(phone);
            Console.WriteLine(customer.ToString());
        }
        public void SearchByAddress()
        {
            Console.WriteLine("Enter Address : ");
            string address = Console.ReadLine();

            List<CustomerModel> customer = service.SearchByAddress(address);
            foreach (CustomerModel c in customer)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public void SearchByAge()
        {
            Console.WriteLine("Enter Age : ");
            int age = int.Parse(Console.ReadLine());

            List<CustomerModel>customer = service.SearchByAge(age);
            foreach(CustomerModel c in customer) 
            {
                Console.WriteLine(c.ToString());
            }
        }
        public string AdvanceMenu() 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("****************************");
            Console.WriteLine("*****  Advance Search  *****");
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose from Below : ");
            Console.WriteLine("1. Search Customer by Name");
            Console.WriteLine("2. Search Customer by First Character");
            Console.WriteLine("3. Search Customer by Phone Number");
            Console.WriteLine("4. Search Customer by Address");
            Console.WriteLine("5. Search Customer by Age");
            Console.WriteLine("6. Back");
            string option = Console.ReadLine();
            return option;
        }
    }
}
