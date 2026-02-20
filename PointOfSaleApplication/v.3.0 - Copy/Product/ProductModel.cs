using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace v._3._0.Product
{
    internal class ProductModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public float purchasePrice { get; set; }
        public float salePrice { get; set; }
        public float discount {  get; set; }

        public ProductModel() { }
        public ProductModel(int id ,string name, float purchasePrice, float salePrice, float discount)
        {
            this.Id = id;
            this.name = name;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.discount = discount;
        }
        public override string ToString()
        {
            return $"ID : {Id},Name : {name}, Purchase Price : {purchasePrice}, Sale Price : {salePrice}, Discount : {discount}";
        }
    }
}