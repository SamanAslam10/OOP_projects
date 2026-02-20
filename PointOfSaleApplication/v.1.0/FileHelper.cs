using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class FileHelper
    {
        public static void WriteIntoProductFile(Product p)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\products.txt";

            StreamWriter writeProducts = new StreamWriter(path, true);

            string record = p.name + "," + p.purchasePrice + "," + p.salePrice + "," + p.discount;
            writeProducts.WriteLine(record);

            writeProducts.Close();
        }
        public static void ReadFromProductFile(List<Product> productslist)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\products.txt";

            StreamReader readProducts = new StreamReader(path);
            string record;
            while ((record = readProducts.ReadLine()) != null)
            {
                string name = parseData(record, 1);
                float purchasePrice = float.Parse(parseData(record, 2));
                float salePrice = float.Parse(parseData(record, 3));
                float discount = float.Parse(parseData(record, 4));

                Product p = new Product(name, purchasePrice, salePrice, discount);
                productslist.Add(p);
            }
            readProducts.Close();

        }
        public static void RewriteProductFile(List<Product>p) 
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\products.txt";

            StreamWriter writeProducts = new StreamWriter(path);

            for (int i = 0; i < p.Count; i++) 
            {
                string record = p[i].name + "," + p[i].purchasePrice + "," + p[i].salePrice + "," +p[i].discount;
                writeProducts.WriteLine(record);
            }
            writeProducts.Close();
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static void ReadFromCustomerFile(List<Customer> customerslist)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\customers.txt";

            StreamReader readCustomers = new StreamReader(path);
            string record;
            while ((record = readCustomers.ReadLine()) != null)
            {
                string name = parseData(record, 1);
                int phoneNumber = int.Parse(parseData(record, 2));
                int age = int.Parse(parseData(record, 3));
                string address = parseData(record, 4);

                Customer c = new Customer(name, phoneNumber, age, address);
                customerslist.Add(c);
            }
            readCustomers.Close();
        }
        public static void WriteIntoCustomerFile(Customer c)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\customers.txt";

            StreamWriter writeCustomer = new StreamWriter(path, true);

            string record = c.name + "," + c.phoneNumber + "," + c.age + "," + c.address;
            writeCustomer.WriteLine(record);

            writeCustomer.Close();
        }
        public static void RewriteCustomerFile(List<Customer> c)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\customers.txt";

            StreamWriter writeCustomers = new StreamWriter(path);

            for (int i = 0; i < c.Count; i++)
            {
                string record = c[i].name + "," + c[i].phoneNumber + "," + c[i].age + "," + c[i].address;
                writeCustomers.WriteLine(record);
            }
            writeCustomers.Close();
        }
        public static void WriteIntoOrdersFile(string name, int phone, int age, string address, List<OrderItem> orders)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\orders.txt";

            StreamWriter writeOrders = new StreamWriter(path, true);

            foreach (OrderItem item in orders)
            {
                string record = name + "," + phone + "," + age + "," + address + "," + item.orderProduct + "," + item.orderQuantity;
                writeOrders.WriteLine(record);
            }
            writeOrders.Close();
        }
        public static void ReadFromOrdersFile(List<OrderHistory> orderslist)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\orders.txt";

            StreamReader readOrders = new StreamReader(path);
            string record;
            while ((record = readOrders.ReadLine()) != null)
            {
                string name = parseData(record, 1);
                int phoneNumber = int.Parse(parseData(record, 2));
                int age = int.Parse(parseData(record, 3));
                string address = parseData(record, 4);
                string product = parseData(record, 5);
                int quantity = int.Parse(parseData(record, 6));

                OrderHistory o= new OrderHistory(name, phoneNumber, age, address , product , quantity);
                orderslist.Add(o);
            }
            readOrders.Close();
        }
    }
}