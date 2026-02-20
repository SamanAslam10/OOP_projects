using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace v._3._0.Product
{
    internal class ProductRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=PointOfSaleApplication;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public bool Create(ProductModel product)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO [Product] (ProductID,Name,PurchasePrice,SalePrice,Discount)" +
                               " VALUES (@Id,@Name,@PurchasePrice,@SalePrice,@Discount)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.name);
                cmd.Parameters.AddWithValue("@PurchasePrice", product.purchasePrice);
                cmd.Parameters.AddWithValue("@SalePrice", product.salePrice);
                cmd.Parameters.AddWithValue("@Discount", product.discount);

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
        public List<ProductModel> GetAll()
        {
            List<ProductModel> productslist = new List<ProductModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT ProductID,Name,PurchasePrice,SalePrice,Discount FROM [Product]";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = Convert.ToString(reader["Name"]);
                    float purchasePrice = Convert.ToSingle(reader["PurchasePrice"]);
                    float salePrice = Convert.ToSingle(reader["SalePrice"]);
                    float discount = Convert.ToSingle(reader["Discount"]);

                    ProductModel product = new ProductModel(id,name, purchasePrice, salePrice, discount);
                    productslist.Add(product);
                }
                conn.Close();
            }
            return productslist;
        }
        public bool Update(ProductModel product)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "UPDATE [Product] SET Name=@Name ,PurchasePrice=@PurchasePrice,SalePrice=@SalePrice,Discount=@Discount" +
                                " WHERE ProductID=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID",product.Id);
                cmd.Parameters.AddWithValue("@Name", product.name);
                cmd.Parameters.AddWithValue("@PurchasePrice", product.purchasePrice);
                cmd.Parameters.AddWithValue("@SalePrice", product.salePrice);
                cmd.Parameters.AddWithValue("@Discount", product.discount);

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
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM [Product] WHERE ProductID=@ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

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
        public ProductModel GetByName(string nameSearch)
        {
            ProductModel product = new ProductModel();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT ProductID,Name,PurchasePrice,SalePrice,Discount FROM [Product] WHERE Name = @Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", nameSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = Convert.ToString(reader["Name"]);
                    float purchasePrice = Convert.ToSingle(reader["PurchasePrice"]);
                    float salePrice = Convert.ToSingle(reader["SalePrice"]);
                    float discount = Convert.ToSingle(reader["Discount"]);

                    ProductModel product2 = new ProductModel(id,name, purchasePrice, salePrice, discount);
                    product = product2;
                }
                conn.Close();
            }
            return product;
        }
        public List<ProductModel> GetAllByPrice(float price)
        {
            List<ProductModel> productslist = new List<ProductModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT ProductID,Name,PurchasePrice,SalePrice,Discount FROM [Product] WHERE SalePrice=@SalePrice";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalePrice", price);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = Convert.ToString(reader["Name"]);
                    float purchasePrice = Convert.ToSingle(reader["PurchasePrice"]);
                    float salePrice = Convert.ToSingle(reader["SalePrice"]);
                    float discount = Convert.ToSingle(reader["Discount"]);

                    ProductModel product = new ProductModel(id,name, purchasePrice, salePrice, discount);
                    productslist.Add(product);
                }
                conn.Close();
            }
            return productslist;
        }
        public List<ProductModel> GetByPriceRange(float startPrice, float endPrice)
        {
            List<ProductModel> productslist = new List<ProductModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT ProductID,Name,PurchasePrice,SalePrice,Discount FROM [Product] WHERE SalePrice BETWEEN @startPrice AND @endPrice";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startPrice", startPrice);
                cmd.Parameters.AddWithValue("@endPrice", endPrice);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = Convert.ToString(reader["Name"]);
                    float purchasePrice = Convert.ToSingle(reader["PurchasePrice"]);
                    float salePrice = Convert.ToSingle(reader["SalePrice"]);
                    float discount = Convert.ToSingle(reader["Discount"]);

                    ProductModel product = new ProductModel(id,name, purchasePrice, salePrice, discount);
                    productslist.Add(product);
                }
                conn.Close();
            }
            return productslist;
        }
        public List<ProductModel> GetByPriceDifference(float difference)
        {
            List<ProductModel> productslist = new List<ProductModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT ProductID,Name,PurchasePrice,SalePrice,Discount FROM [Product] WHERE ABS((SalePrice - PurchasePrice) - @difference) < 0.001";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@difference", difference);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = Convert.ToString(reader["Name"]); name = name.Trim();
                    float purchasePrice = Convert.ToSingle(reader["PurchasePrice"]);
                    float salePrice = Convert.ToSingle(reader["SalePrice"]);
                    float discount = Convert.ToSingle(reader["Discount"]);

                    ProductModel product = new ProductModel(id, name, purchasePrice, salePrice, discount);
                    productslist.Add(product);
                }
                conn.Close();
            }
            return productslist;
        }
        public List<ProductModel> GetAllBySubString(string substring)
        {
            List<ProductModel> productslist = new List<ProductModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT ProductID,Name,PurchasePrice,SalePrice,Discount FROM [Product] WHERE Name LIKE '%' + @substring + '%'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@substring", substring);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ProductID"]);
                    string name = Convert.ToString(reader["Name"]);
                    float purchasePrice = Convert.ToSingle(reader["PurchasePrice"]);
                    float salePrice = Convert.ToSingle(reader["SalePrice"]);
                    float discount = Convert.ToSingle(reader["Discount"]);

                    ProductModel product = new ProductModel(id,name, purchasePrice, salePrice, discount);
                    productslist.Add(product);
                }
                conn.Close();
            }
            return productslist;
        }
    }
}