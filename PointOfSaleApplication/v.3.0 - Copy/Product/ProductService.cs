using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace v._3._0.Product
{
    internal class ProductService
    {
        private ProductRepoDB repoDB = new ProductRepoDB();

        public void AddProduct(ProductModel product)
        {
            repoDB.Create(product);
        }
        public void UpdateProduct(ProductModel product)
        {
            repoDB.Update(product);
        }
        public void DeleteProduct(int id)
        {
            repoDB.Delete(id);
        }
        public List<ProductModel> GetAllData()
        {
            return repoDB.GetAll();
        }


        // Advance Features 
        public List<ProductModel> SearchAllProductsbyPrice(float salePrice)
        {
            List<ProductModel> products = repoDB.GetAllByPrice(salePrice);
            return products;
        }
        public List<ProductModel> SearchByPriceRange(float start, float end)
        {
            List<ProductModel> products = repoDB.GetByPriceRange(start, end);
            return products;
        }
        public List<ProductModel> SearchByPriceDifference(float priceDifference)
        {
            List<ProductModel> products = repoDB.GetByPriceDifference(priceDifference);
            return products;
        }
        public List<ProductModel> SearchBySubString(string characters)
        {
            List<ProductModel> productsList = repoDB.GetAll();
            List<ProductModel> searchBySubStringList = new List<ProductModel>();

            foreach (ProductModel p in productsList)
            {
                if (p.name.Contains(characters))
                {
                    searchBySubStringList.Add(p);
                }
            }
            return searchBySubStringList;
        }
        public List<ProductModel> SearchByName(string name)
        {
            ProductModel productModel = repoDB.GetByName(name);
            List<ProductModel> products = new List<ProductModel>();
            products.Add(productModel);
            return products;
        }
    }
}