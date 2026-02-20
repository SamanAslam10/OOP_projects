using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApplication
{
    internal class UserService
    {
        UserRepo userRepo = new UserRepo();
        public void AddUser(UserModel user) 
        {
           bool addUser = userRepo.Create(user);
            if (addUser == true) 
            {
                Console.WriteLine("New User added Successfully!");
            }
            else
            {
                Console.WriteLine("Could not add User!");
            }
        }
        public List<UserModel> ViewAllUsers() 
        {
            List<UserModel> usersList = new List<UserModel>();
            usersList = userRepo.GetAll();
            return usersList;
        }
        public void UpdateByName(string oldname) 
        {
            Console.WriteLine("Enter the Updated Info ");
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

            UserModel user = new UserModel(name, age, contact, color, movie);
            bool updateUser = userRepo.Update(user , oldname);
            if (updateUser == true)
            {
                Console.WriteLine("User Updated Successfully!");
            }
            else 
            {
                Console.WriteLine("Couldn't Update User!");
            }
        }
        public void DeleteByName(string name) 
        {
            bool delete = userRepo.Delete(name);
            if (delete == true)
            {
                Console.WriteLine("Record Delt Successfully!");
            }
            else 
            {
                Console.WriteLine("Couldn't Delete Record!");
            }

        }
    }
}
