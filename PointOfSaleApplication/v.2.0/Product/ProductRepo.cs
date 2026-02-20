using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Product
{
    internal class ProductRepo
    {
        private readonly string file = "S:\\CS\\semester2\\OOP\\Lab\\code\\Project1\\v.2.0\\products.txt";

        public ProductRepo() { }

        public void SaveInFile(ProductModel product) 
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(product.ToString());
            }
        }
        public void SaveAllDataIntoFile(List<ProductModel> productslist) 
        {
            File.WriteAllText(file, string.Empty);
            foreach (ProductModel product in productslist) 
            {
                SaveInFile(product);
            }
        }
        public List<ProductModel> GetProductsFromFile() 
        {
            List<ProductModel>productsList = new List<ProductModel>();

            using (StreamReader reader = new StreamReader(file)) 
            {
                string line = "";
                while ((line = reader.ReadLine()) != null) 
                {
                    string[] parts = line.Split(',');
                    string productName = parts[0];
                    float productPurchasePrice = float.Parse(parts[1]);
                    float productSalePrice = float.Parse(parts[2]);
                    float productDiscount = float.Parse(parts[3]);

                    ProductModel product = new ProductModel(productName,productPurchasePrice,productSalePrice,productDiscount);
                    productsList.Add(product);
                }
            }
            return productsList;
        }
    }
}