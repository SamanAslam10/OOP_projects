using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 

namespace v._3._0.Order
{
    internal class OrderRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=PointOfSaleApplication;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public bool Create(OrderModel order)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection)) 
            {
                conn.Open();
                string query = "INSERT INTO [Order] CustomerID , ProductID , ProductName , Price , Qunatity , Discount , Total " +
                                "VALUES @CustomerID , @ProductID , @ProductName , @Price ,@Quantity , @Discount , @Total";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", order.CustomerId);
                cmd.Parameters.AddWithValue("@ProductID" , order.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", order.productName);
                cmd.Parameters.AddWithValue("@Price", order.price);
                cmd.Parameters.AddWithValue("@Quantity", order.quantity);
                cmd.Parameters.AddWithValue("@Discount", order.discount);
                cmd.Parameters.AddWithValue("@Total", order.total);

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
        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> ordersList = new List<OrderModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "Select CustomerID , ProductID , ProductName , Price , Quantity , Discount , Total FROM [Order]";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int CustomerID = Convert.ToInt32(reader["CustomerID"]);
                    int ProductID = Convert.ToInt32(reader["ProductID"]);
                    string ProductName = Convert.ToString(reader["ProductName"]);
                    float Price = Convert.ToSingle(reader["Price"]);
                    int Quantity = Convert.ToInt32(reader["Quantity"]);
                    float Discount = Convert.ToSingle(reader["Discount"]);
                    float Total = Convert.ToSingle(reader["Total"]);


                    OrderModel order = new OrderModel(CustomerID , ProductID , ProductName , Price , Quantity , Discount , Total);
                    ordersList.Add(order);
                }
            }
            return ordersList;
        }
    }
}