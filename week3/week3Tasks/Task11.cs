using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User>flowersList = new List<User>();
            int option = Login();
            while (true) 
            {
                if (option == 1)
                {
                    int option2 = AdminMenu();
                    if (option2 == 1)
                    {
                        Console.WriteLine("Enter the name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the price : ");
                        float price = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the stock : ");
                        int stock = int.Parse(Console.ReadLine());

                        User flower = new User(name, price, stock);
                        flowersList.Add(flower);
                    }
                    else if (option2 == 2)
                    {
                        foreach (User flower in flowersList)
                        {
                            flower.ReadFlower(flowersList);
                            break;
                        }
                    }
                    else if (option2 == 3)
                    {
                        foreach (User flower in flowersList)
                        {
                            flower.UpdateFlower(flowersList);
                        }
                    }
                    else if (option2 == 4)
                    {
                        foreach (User flower in flowersList)
                        {
                            flower.DelFlower(flowersList);
                        }
                    }
                    else if (option2 == 5) 
                    {
                        break;
                    }
                }
                else if (option == 2)
                {
                    int option3 = UserMenu();
                    if (option3 == 1)
                    {
                        foreach (User flower in flowersList)
                        {
                            flower.ReadFlower(flowersList);
                        }
                    }
                }
            }
        }
        static int Login() 
        {
            Console.WriteLine("Login as Admin(1) / User (2) : ");
            int option = int.Parse(Console.ReadLine());
            if(option == 1)
            {//admin
                Console.WriteLine("Enter username : ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                string password = Console.ReadLine();
                return option;
            }
            else if(option == 2) 
            { //User
                Console.WriteLine("SignIN (1) / SignUP (2)");
                int option2 = int.Parse(Console.ReadLine());
                if (option2 == 1) 
                {
                    // Sign In
                    Console.WriteLine("Enter username : ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string password = Console.ReadLine();

                    string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\week3\\week3Tasks\\userLogin.txt";
                    StreamReader userLogin = new StreamReader(path);
                    string record;
                    while((record = userLogin.ReadLine()) != null) 
                    {
                        string usernameFile = parseData(record, 1);
                        string passwordFile = parseData(record, 2);
                        if (username == usernameFile && password == passwordFile) 
                        {
                            Console.WriteLine("Valid Credentials! Welcome to Flower Shop");
                            return option;
                        }
                        else 
                        {
                            Console.WriteLine("Wrong Credentials! Try Again");
                        }
                    }
                    userLogin.Close();
                }
                else if (option2 == 2) 
                {
                    // Sign UP
                    Console.WriteLine("Enter username : ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    string password = Console.ReadLine();

                    string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\week3\\week3Tasks\\userLogin.txt";
                    StreamWriter userLogin = new StreamWriter(path , true);
                    userLogin.WriteLine(username + "," + password); 
                    userLogin.Flush();
                    userLogin.Close();
                    
                }
            }
            return option;
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

        static int AdminMenu() 
        {
            Console.WriteLine("Choose from Menu : ");
            Console.WriteLine("1. Add a Flower");
            Console.WriteLine("2. Read a Flower");
            Console.WriteLine("3. Update a Flower");
            Console.WriteLine("4. Delete a Flower");
            Console.WriteLine("5. Exit");
            int option = int.Parse(Console.ReadLine());

            return option;
        }
        static int UserMenu()
        {
            Console.WriteLine("Choose from Menu : ");
            Console.WriteLine("1. View Flowers");
            int option = int.Parse(Console.ReadLine());

            return option;
        }
    }
    class User 
    {
        public int FlowerID;
        public string FlowerName;
        public float FlowerPrice;
        public int FlowerStock;

        public User(string FlowerName , float FlowerPrice , int FlowerStock) 
        {
            this.FlowerName = FlowerName;
            this.FlowerPrice = FlowerPrice;
            this.FlowerStock = FlowerStock;
        }
        public void ReadFlower(List<User> flowersList)
        {
            foreach (User flower in flowersList)
            {
                Console.WriteLine("ID : " + flower.FlowerID + " Name : " + flower.FlowerName + " Price : " + flower.FlowerPrice + " Stock : " + flower.FlowerStock);
            }
        }
        public void UpdateFlower(List<User> flowerslist) 
        {
            Console.WriteLine("Enter the id of Flower you want to Update : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Which Attribute of Flower you want to update : ");
            string attribute = Console.ReadLine();
            foreach (User flower in flowerslist)
            {
                if (flower.FlowerID == id)
                {
                    if (attribute == "name") 
                    {
                        Console.WriteLine("Enter the update name : ");
                        flower.FlowerName = Console.ReadLine();
                    }
                    if (attribute == "price")
                    {
                        Console.WriteLine("Enter the update price : ");
                        flower.FlowerPrice = float.Parse(Console.ReadLine());
                    }
                    if (attribute == "stock")
                    {
                        Console.WriteLine("Enter the update stock : ");
                        flower.FlowerStock = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public void DelFlower(List<User>flowersList) 
        {
            Console.WriteLine("Enter the id of Flower you want to Delete : ");
            int id = int.Parse (Console.ReadLine());
            foreach (User flower in flowersList) 
            {
                if (flower.FlowerID == id) 
                {
                    flowersList.Remove(flower);
                    break;
                }
            }
        }

    }
}