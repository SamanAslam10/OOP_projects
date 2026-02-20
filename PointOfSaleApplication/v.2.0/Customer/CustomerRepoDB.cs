using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Customer
{
    internal class CustomerRepoDB
    {
        private readonly string DbConnection = "Server=localhost;Database=PointOfSaleApplication;Trusted_Connection=True;";
        public bool Create(CustomerModel customer) 
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO Customer (Name, Age, PhoneNumber, Adress)" +
                                " VALUES (@Name, @Age, @PhoneNumber, @Adress)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", customer.name);
                cmd.Parameters.AddWithValue("@Age", customer.age);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Adress", customer.address);

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
        public List<CustomerModel> GetAll() 
        {
            List<CustomerModel> customersList = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                conn.Open();
                string query = "SELECT Name,Age,PhoneNumber,Adress FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Contact = Convert.ToString(reader["Adress"]);

                    CustomerModel customer = new CustomerModel(name , PhoneNumber , age, Contact);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
        public bool Delete(string name) 
        {
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                conn.Open();
                string query = "DELETE FROM Customer WHERE Name=@Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);

                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected > 0) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }
        public bool Update(CustomerModel customer) 
        {
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                conn.Open();
                string query = "UPDATE Customer SET Name=@Name,Age=@Age,PhoneNumber=@PhoneNumber,Adress=@Adress" +
                                " WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", customer.name);
                cmd.Parameters.AddWithValue("@Age", customer.age);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Adress", customer.address);

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
        public List<CustomerModel> GetByAge(int ageSearch)
        {
            List<CustomerModel> customersList = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT Name,Age,PhoneNumber,Adress FROM Customer WHERE Age=@Age";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Age", ageSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Contact = Convert.ToString(reader["Adress"]);

                    CustomerModel customer = new CustomerModel(name, PhoneNumber, age, Contact);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
        public List<CustomerModel> GetByName(string nameSearch)
        {
            List<CustomerModel> customersList = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT Name,Age,PhoneNumber,Adress FROM Customer WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", nameSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Contact = Convert.ToString(reader["Adress"]);

                    CustomerModel customer = new CustomerModel(name, PhoneNumber, age, Contact);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
        public List<CustomerModel> GetByAddress(string AddressSearch)
        {
            List<CustomerModel> customersList = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT Name,Age,PhoneNumber,Adress FROM Customer WHERE Adress=@Address";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Address", AddressSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Contact = Convert.ToString(reader["Adress"]);

                    CustomerModel customer = new CustomerModel(name, PhoneNumber, age, Contact);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
        public CustomerModel GetByPhone(string phoneSearch)
        {
            CustomerModel customerModel = new CustomerModel();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT Name,Age,PhoneNumber,Adress FROM Customer WHERE PhoneNumber=@PhoneNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Contact = Convert.ToString(reader["Adress"]);

                    CustomerModel customer = new CustomerModel(name, PhoneNumber, age, Contact);
                    customerModel = customer;
                }
                conn.Close();
            }
            return customerModel;
        }
        public List<CustomerModel> GetByFirstChar(string firstChar)
        {
            List<CustomerModel> customersList = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT Name,Age,PhoneNumber,Adress FROM Customer WHERE Name LIKE @firstchar";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstchar",firstChar + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Contact = Convert.ToString(reader["Adress"]);

                    CustomerModel customer = new CustomerModel(name, PhoneNumber, age, Contact);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
    }
}
