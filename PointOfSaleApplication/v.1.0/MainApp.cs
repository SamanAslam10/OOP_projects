using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            FileHelper.ReadFromProductFile(productList);

            List<Customer> customersList = new List<Customer>();
            FileHelper.ReadFromCustomerFile(customersList);

            List<OrderHistory> ordersList = new List<OrderHistory>();
            FileHelper.ReadFromOrdersFile(ordersList);

            while (true)
            {
                Menu menu = new Menu();
                int option = menu.MainMenu();
                Console.Clear();
                if (option == 1)
                {
                    while (true)
                    {
                        int optionProduct = menu.ProductManagement();
                        Product products = new Product();
                        Console.Clear();

                        if (optionProduct == 1)
                        {
                            products.AddProducts(productList);
                            FileHelper.WriteIntoProductFile(products);
                        }
                        else if (optionProduct == 2)
                        {
                            products.UpdateProducts(productList);
                            FileHelper.RewriteProductFile(productList);

                        }
                        else if (optionProduct == 3)
                        {
                            products.DeleteProducts(productList);
                            FileHelper.RewriteProductFile(productList);
                        }
                        else if (optionProduct == 4)
                        {
                            products.ViewProducts(productList);
                        }
                        else if (optionProduct == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                        }
                    }
                }
                else if (option == 2)
                {
                    while (true)
                    {
                        int optionCustomer = menu.CustomerManagement();
                        Customer customer = new Customer();
                        Console.Clear();

                        if (optionCustomer == 1)
                        {
                            customer.AddNewCustomer(customersList);
                            FileHelper.WriteIntoCustomerFile(customer);
                        }
                        else if (optionCustomer == 2)
                        {
                            customer.UpdateCustomer(customersList);
                            FileHelper.RewriteCustomerFile(customersList) ;
                        }
                        else if (optionCustomer == 3)
                        {
                            customer.DeleteCustomer(customersList);
                            FileHelper.RewriteCustomerFile(customersList);
                        }
                        else if (optionCustomer == 4)
                        {
                            customer.ViewCustomers(customersList);
                        }
                        else if (optionCustomer == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                        }
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter the Name of Customer : ");
                    string name = Console.ReadLine();

                    OrderItem orderItem = new OrderItem(customersList, productList);
                    bool checkcustomer = orderItem.CheckCustomer(name);
                    List<OrderItem> orderslist = new List<OrderItem>();
                    if (checkcustomer == false)
                    {
                        Customer customer = new Customer();

                        customer.AddNewCustomer(customersList);
                        FileHelper.WriteIntoCustomerFile(customer);
                        while (true)
                        {
                            Console.Write("Do you want to add products (yes/no) : ");
                            string choice = Console.ReadLine();

                            if (choice == "yes")
                            {
                                orderslist = orderItem.OrderProducts();
                            }
                            else if (choice == "no")
                            {
                                foreach (Customer c in customersList)
                                {
                                    if (name == c.name)
                                    {
                                        FileHelper.WriteIntoOrdersFile(c.name, c.phoneNumber, c.age, c.address, orderslist);
                                    }
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Do you want to add products (yes/no) : ");
                            string choice = Console.ReadLine();

                            if (choice == "yes")
                            {
                                orderslist = orderItem.OrderProducts();
                            }
                            else if (choice == "no")
                            {
                                foreach (Customer c in customersList)
                                {
                                    if (name == c.name)
                                    {
                                        FileHelper.WriteIntoOrdersFile(c.name, c.phoneNumber, c.age, c.address, orderslist);
                                    }
                                }
                                break;
                            }
                        }
                    }

                }
                else if (option == 4)
                {

                    while (true)
                    {
                        OrderHistory orderHistory = new OrderHistory();
                        int historyOption = menu.OrderHistory();
                        Console.Clear();

                        if (historyOption == 1)
                        {
                            orderHistory.ViewOrderHistory(ordersList);
                        }
                        else if (historyOption == 2)
                        {
                            orderHistory.SearchForOrder(ordersList);
                        }
                        else if (historyOption == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Option!");
                        }
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("Exiting the Application!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option!");
                }
            }
        }
    }
}
