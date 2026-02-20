using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Product
{
    internal class ProductUI
    {
        ProductService service = new ProductService();
        public void ProductDriver() 
        {
            while (true) 
            {
                Console.Clear();
                string option = ProductMenu();
                if (option == "1")
                {
                    ProductModel product = TakeInput();
                    service.AddProduct(product);
                }
                else if (option == "2")
                {
                    UpdateProduct();
                }
                else if (option == "3")
                {
                    DeleteProduct();
                }
                else if (option == "4") 
                {
                    DisplayAllData();
                }
                else if (option == "5")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong Choice");
                }
                Console.ReadKey();
            }
        }
        public void UpdateProduct() 
        {
            Console.Write("Enter the Product Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter the Product Updated Purchase Price : ");
            float purchasePrice = float.Parse(Console.ReadLine());
            Console.Write("Enter the Product Updated Sale Price : ");
            float salePrice = float.Parse(Console.ReadLine());
            Console.Write("Enter the Product Updated Discount : ");
            float discount = float.Parse(Console.ReadLine());

            ProductModel product = new ProductModel(name , purchasePrice , salePrice , discount);
            service.UpdateProduct(product );
        }
        public void DeleteProduct()
        {
            Console.WriteLine("Enter the Product Name : ");
            string name = Console.ReadLine();

            service.DeleteProduct(name);
        }
        public void DisplayAllData() 
        {
            foreach(ProductModel p in service.GetAllData()) 
            {
                Console.WriteLine(p.ToString());
            }
        }
        public ProductModel TakeInput()
        {
            Console.WriteLine("Enter the Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Product Purchase Price : ");
            float purchasePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Sale Price : ");
            float salePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Discount : ");
            float discount = float.Parse(Console.ReadLine());

            ProductModel product = new ProductModel(name , purchasePrice , salePrice , discount);
            return product;
        }
        public string ProductMenu() 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("********************************");
            Console.WriteLine("*****  PRODUCT MANAGEMENT  *****");
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Update Product");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. View All Products");
            Console.WriteLine("5. Back to Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your Choice : ");
            string choice = Console.ReadLine();
            return choice;
        }
        public void AdvanceSearch() 
        {
            while (true) 
            {
                Console.Clear();
                string option = AdvanceMenu();
                if (option == "1") 
                {
                    SearchByName();
                }
                else if (option == "2") 
                {
                    SearchAllProductsbyPrice();
                }
                else if (option == "3") 
                {
                    SearchProductsWithinAPriceRange();
                }
                else if (option == "4") 
                {
                    SearchByPriceDifference();
                }
                else if (option == "5") 
                {
                    SearchBySubString();
                }
                else if (option == "6") 
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option!");
                }
                Console.ReadKey();
            }
        }
        public void SearchByName() 
        {
            Console.WriteLine("Enter the Name of Product you want to Search : ");
            string name = Console.ReadLine();
            ProductModel productByName = service.SearchByName(name);
            if (productByName != null)
            {
                Console.WriteLine(productByName.ToString());
            }
            else
            {
                Console.WriteLine("No Product with name '" + name + "' found.");
            }
        }
        public void SearchAllProductsbyPrice() 
        {
            Console.WriteLine("Enter the Price of Product you want to Search : ");
            float price = float.Parse(Console.ReadLine());

            List<ProductModel> productsByPriceList = new List<ProductModel>();
            productsByPriceList = service.SearchAllProductsbyPrice(price);

            for (int i = 0; i < productsByPriceList.Count; i++) 
            {
                Console.WriteLine(productsByPriceList[i].ToString());
            }
        }
        public void SearchProductsWithinAPriceRange() 
        {
            Console.WriteLine("Enter the Price Range : ");
            Console.Write("Starting Price : ");
            float start = float.Parse(Console.ReadLine());
            Console.Write("Ending Price : ");
            float end = float.Parse(Console.ReadLine());

            List<ProductModel> RangePriceList = new List<ProductModel>();
            RangePriceList = service.SearchByPriceRange(start, end);
            foreach (ProductModel p in RangePriceList)
            {
                Console.WriteLine(p.ToString());
            }
        }
        public void SearchByPriceDifference() 
        {
            Console.WriteLine("Enter the Price Difference : ");
            float priceDifference = float.Parse(Console.ReadLine());

            List<ProductModel> priceDifferenceList = new List<ProductModel>();
            priceDifferenceList = service.SearchByPriceDifference(priceDifference);
            foreach (ProductModel p in priceDifferenceList)
            {
                Console.WriteLine(p.ToString());
            }
        }
        public void SearchBySubString() 
        {
            Console.Write("Enter the characters : ");
            string characters = Console.ReadLine();

            List<ProductModel> searchBySubStringList = service.SearchBySubString( characters );
            foreach (ProductModel p in searchBySubStringList)
            {
                Console.WriteLine(p.ToString());
            }
        }
        public string AdvanceMenu() 
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("****************************");
            Console.WriteLine("*****  Advance Search  *****");
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose from Below : ");
            Console.WriteLine("1. Search Product by Name");
            Console.WriteLine("2. Search All Products by Price");
            Console.WriteLine("3. Search Products within a Price Range");
            Console.WriteLine("4. Search Products by Price Difference");
            Console.WriteLine("5. Search Products by SubString");
            Console.WriteLine("6. Back");
            string option = Console.ReadLine();
            return option;
        }
    }
}