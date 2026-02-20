using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace v._2._0.Order
{
    internal class OrderRepoDB
    {
        private readonly string DbConnection = "Server=localhost;Database=PointOfSaleApplication;Trusted_Connection=True;";

        public bool Create(OrderModel order, List<OrderItem> items)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                List<String> Products = new List<String>();
                List<Int32> Quantity = new List<Int32>();
                List<float> SalePrice = new List<float>();
                foreach (OrderItem item in items)
                {
                    Products.Add(item.product);
                    Quantity.Add(item.quantity);
                    SalePrice.Add(item.salePrice);
                }
                string allProducts = string.Join(",", Products);
                string allQuantity = string.Join(",", Quantity);
                string allSalePrice = string.Join(",", SalePrice);

                conn.Open();
                string query = "INSERT INTO [Order] (Name,Age,PhoneNumber,Address,Product,Quantity,SalePrice)" +
                                " VALUES (@Name,@Age,@PhoneNumber,@Address,@Product,@Quantity,@SalePrice)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", order.customerName);
                cmd.Parameters.AddWithValue("@Age", order.age);
                cmd.Parameters.AddWithValue("@PhoneNumber", order.phoneNumber);
                cmd.Parameters.AddWithValue("@Address", order.address);

                cmd.Parameters.AddWithValue("@Product", allProducts);
                cmd.Parameters.AddWithValue("@Quantity", allQuantity);
                cmd.Parameters.AddWithValue("@SalePrice", allSalePrice);

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
                string query = "Select Name,Age,PhoneNumber,Address,Product,Quantity,SalePrice FROM [Order]";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderModel order = new OrderModel();
                    order.customerName = Convert.ToString(reader["Name"]);
                    order.age = Convert.ToInt32(reader["Age"]);
                    order.phoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    order.address = Convert.ToString(reader["Address"]);

                    string[] Products = Convert.ToString(reader["Product"]).Split(',');
                    string[] Quantity = Convert.ToString(reader["Quantity"]).Split(',');
                    string[] SalePrice = Convert.ToString(reader["SalePrice"]).Split(',');

                    List<OrderItem> ItemsList = new List<OrderItem>();
                    for (int i = 0; i < Products.Length; i++)
                    {
                        OrderItem item = new OrderItem
                        {
                            product = Products[i].Trim(),
                            quantity = int.Parse(Quantity[i]),
                            salePrice = float.Parse(SalePrice[i]),
                        };
                        ItemsList.Add(item);
                    }
                    order.items = ItemsList;
                    ordersList.Add(order);
                }
            }
            return ordersList;
        }
    }
}