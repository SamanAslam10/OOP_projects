using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApplication
{
    internal class UserUI
    {
        UserService userService = new UserService();
        public void Start() 
        {
            while (true) 
            {
                string option = Menu();
                if (option == "1")
                {
                    AddUser();
                }
                else if (option == "2") 
                {
                    ViewAllUsers();
                }
                else if (option == "3") 
                {
                    UpdateByName();
                }
                else if (option == "4") 
                {
                    DeleteByName();
                }
                else if (option == "5") 
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong Option!");
                }
            }
        }
        public void AddUser() 
        {
            Console.Write(" Name : ");
            string name = Console.ReadLine();
            Console.Write(" Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write(" Contact : ");
            string contact = Console.ReadLine();
            Console.Write(" Favourite Color : ");
            string color = Console.ReadLine();
            Console.Write(" Favourite Movie : ");
            string movie = Console.ReadLine();

            UserModel user = new UserModel(name , age , contact ,color , movie);
            userService.AddUser(user);
        }
        public void ViewAllUsers() 
        {
            UserModel userModel = new UserModel();
            List<UserModel> usersList = new List<UserModel> ();
            usersList = userService.ViewAllUsers();

            foreach (UserModel user in usersList) 
            {
                Console.WriteLine(userModel.ToString(user));
            }
        }
        public void UpdateByName() 
        {
            Console.Write("Enter the Name of User : ");
            string name = Console.ReadLine();

            userService.UpdateByName(name);
        }
        public void DeleteByName() 
        {
            Console.Write("Enter the Name of User : ");
            string name = Console.ReadLine();

            userService.DeleteByName(name);
        }
        static string Menu() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*****************************");
            Console.WriteLine(" User Management Application ");
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. View All Users");
            Console.WriteLine("3. Update a User by Name");
            Console.WriteLine("4. Delete a User by Name");
            Console.WriteLine("5. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter Choice : ");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
