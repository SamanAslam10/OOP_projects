using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApplication
{
    internal class UserRepo
    {
        public readonly string DbConnection = "Server=localhost;Database=UserManagement;Trusted_Connection=True;";
        public bool Create(UserModel user) 
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                string query = "INSERT INTO [User] (Name, Age, Contact, FavouriteColor, FavouriteMovie)" +
                                " VALUES (@Name, @Age, @Contact, @FavouriteColor, @FavouriteMovie)";
                SqlCommand cmd = new SqlCommand(query , conn);
                cmd.Parameters.AddWithValue("@Name", user.name);
                cmd.Parameters.AddWithValue("@Age", user.age);
                cmd.Parameters.AddWithValue("@Contact", user.contact);
                cmd.Parameters.AddWithValue("@FavouriteColor", user.favouriteColor);
                cmd.Parameters.AddWithValue("@FavouriteMovie", user.favouriteMovie);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        public List<UserModel> GetAll() 
        {
            List<UserModel> UsersList = new List<UserModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                conn.Open();
                string query = "SELECT Name , Age , Contact , FavouriteColor , FavouriteMovie FROM [User]";
                SqlCommand cmd = new SqlCommand (query , conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    string Name = Convert.ToString(reader["Name"]);
                    int Age = Convert.ToInt32(reader["Age"]);
                    string Contact = Convert.ToString(reader["Contact"]);
                    string FavouriteColor = Convert.ToString(reader["FavouriteColor"]);
                    string FavouriteMovie = Convert.ToString(reader["FavouriteMovie"]);

                    UserModel user = new UserModel(Name , Age , Contact , FavouriteColor , FavouriteMovie);   
                    UsersList.Add(user);
                }
                conn.Close();
            }
            return UsersList;
        }
        public bool Update(UserModel user , string oldname) 
        {
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                string query = "UPDATE [User] SET Age=@Age, Contact=@Contact, FavouriteColor=@FavouriteColor , FavouriteMovie=@FavouriteMovie" +
                                " WHERE Name=@Name";
                
                SqlCommand cmd = new SqlCommand(query , conn);
                cmd.Parameters.AddWithValue("@Name", oldname);
                cmd.Parameters.AddWithValue("@Age", user.age);
                cmd.Parameters.AddWithValue("@Contact", user.contact);
                cmd.Parameters.AddWithValue("@FavouriteColor", user.favouriteColor);
                cmd.Parameters.AddWithValue("@FavouriteMovie", user.favouriteMovie);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        public bool Delete(string name)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                string query = "DELETE FROM [User] WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
    }
}