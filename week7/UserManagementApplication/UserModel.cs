using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApplication
{
    internal class UserModel
    {
        public string name {  get; set; }
        public int age { get; set; }
        public string contact { get; set; }
        public string favouriteColor { get; set; }
        public string favouriteMovie { get; set; }

        public UserModel() { }
        public UserModel(string name , int age , string contact , string favouriteColor , string favouriteMovie) 
        {
            this.name = name;
            this.age = age;
            this.contact = contact;
            this.favouriteColor = favouriteColor;
            this.favouriteMovie = favouriteMovie;
        }
        public string ToString(UserModel user) 
        {
            return $"Name : {user.name}, Age : {user.age}, Contact : {user.contact}, FavouriteColor : {user.favouriteColor}, Favourite Movie : {user.favouriteMovie}";
        }
    }
}
