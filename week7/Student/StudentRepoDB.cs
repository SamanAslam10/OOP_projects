using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class StudentRepoDB
    {
        public readonly string DbConnection = "Server=localhost;Database=StudentInfo;Trusted_Connection=True;";

        public bool Create(StudentModel student) 
        {
            using (SqlConnection connection = new SqlConnection(DbConnection)) 
            {
                string query = "INSERT INTO STUDENT (Name,Age,Address ,CGPA) " + 
                    "VALUES(@Name,@Age,@Address,@CGPA)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Name" , student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Address" , student.Address);
                cmd.Parameters.AddWithValue("@CGPA" , student.CGPA);

                connection.Open();
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
        public bool Delete(int id) 
        {
            using (SqlConnection connection = new SqlConnection(DbConnection)) 
            {
                string query = "DELETE FROM STUDENT WHERE Id = @Id ";
                SqlCommand cmd = new SqlCommand(query , connection);
                cmd.Parameters.AddWithValue ("@Id" , id);

                connection.Open();
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
        public bool Update(StudentModel student , int id) 
        {
            using (SqlConnection connection = new SqlConnection(DbConnection))
            {
                string query = "UPDATE Student SET Name = @Name , Age = @Age," + "Address = @Address , CGPA = @CGPA WHERE Id = @Id";
                
                SqlCommand command = new SqlCommand(query , connection);
                command.Parameters.AddWithValue("@Id" , student.Id);
                command.Parameters.AddWithValue("@Name" , student.Name);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@Age" , student.Age);
                command.Parameters.AddWithValue("@CGPA" , student.CGPA);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
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
        public List<StudentModel> GetStudents() 
        {
            List<StudentModel> studentsList = new List<StudentModel>();
            using (SqlConnection connection = new SqlConnection(DbConnection)) 
            {
                connection.Open();
                string query = "SELECT Id , Name , Age , Address , CGPA FROM STUDENT";
                SqlCommand command = new SqlCommand (query , connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string name = Convert.ToString(reader["Name"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    string address = Convert.ToString(reader["Address"]);
                    float cgpa = Convert.ToSingle(reader["CGPA"]);
                    
                    StudentModel student = new StudentModel(id , name , age , address , cgpa);
                    StudentModel student1 = new StudentModel(name,age , address ,cgpa);

                    studentsList.Add(student);
                }
                reader.Close();
            }
            return studentsList;
        }
    }
}