using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace v._3._0.Customer
{
    internal class CustomerRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=PointOfSaleApplication;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public bool Create(CustomerModel customer)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO Customer (CustomerID,Name, Age, PhoneNumber, Address)" +
                                " VALUES (@Id,@Name, @Age, @PhoneNumber, @Address)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id",customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.name);
                cmd.Parameters.AddWithValue("@Age", customer.age);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Address", customer.address);

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
                string query = "SELECT CustomerID,Name,Age,PhoneNumber,Address FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Address = Convert.ToString(reader["Address"]);

                    CustomerModel customer = new CustomerModel(id,name, PhoneNumber, age, Address);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM Customer WHERE CustomerID=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

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
        public bool Update(CustomerModel customer)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "UPDATE Customer SET Name=@Name,Age=@Age,PhoneNumber=@PhoneNumber,Address=@Address" +
                                " WHERE CustomerID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id",customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.name);
                cmd.Parameters.AddWithValue("@Age", customer.age);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Address", customer.address);

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
                string query = "SELECT CustomerID,Name,Age,PhoneNumber,Address FROM Customer WHERE Age=@Age";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Age", ageSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Address = Convert.ToString(reader["Address"]);

                    CustomerModel customer = new CustomerModel(id,name, PhoneNumber, age, Address);
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
                string query = "SELECT CustomerID,Name,Age,PhoneNumber,Address FROM Customer WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", nameSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Address = Convert.ToString(reader["Address"]);

                    CustomerModel customer = new CustomerModel(id,name, PhoneNumber, age, Address);
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
                string query = "SELECT CustomerID,Name,Age,PhoneNumber,Adress FROM Customer WHERE Address=@Address";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Address", AddressSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Address = Convert.ToString(reader["Address"]);

                    CustomerModel customer = new CustomerModel(id,name, PhoneNumber, age, Address);
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
                string query = "SELECT CustomerID,Name,Age,PhoneNumber,Address FROM Customer WHERE PhoneNumber=@PhoneNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Address = Convert.ToString(reader["Address"]);

                    CustomerModel customer = new CustomerModel(id,name, PhoneNumber, age, Address);
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
                string query = "SELECT CustomerID,Name,Age,PhoneNumber,Address FROM Customer WHERE Name LIKE @firstchar";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstchar", firstChar + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string Address = Convert.ToString(reader["Address"]);

                    CustomerModel customer = new CustomerModel(id,name, PhoneNumber, age, Address);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
    }
}