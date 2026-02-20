using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Product
{
    internal class ProductModel
    {
        public string name;
        public float purchasePrice;
        public float salePrice;
        public float discount;

        public ProductModel() { }
        public ProductModel(string name , float purchasePrice , float salePrice , float discount)
        {
            this.name = name;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.discount = discount;
        }

        // Get-er nd Set-ers
        public void SetName(string name) 
        {
            this.name = name;
        }
        public string GetName() 
        {
            return this.name;
        }
        public void SetPurchasePrice(float purchasePrice) 
        {
            this.purchasePrice = purchasePrice;
        }
        public float GetPurchasePrice() 
        {
            return this.purchasePrice;
        }
        public void SetSalePrice(float salePrice)
        {
            this.salePrice = salePrice;
        }
        public float GetSalePrice() 
        {
            return this.salePrice - discount;
        }
        public void SetDiscount(float discount)
        {
            this.discount = discount;
        }
        public float GetDiscount() 
        {
            return this.discount;
        }
        public override string ToString() 
        {
            return $"Name : {name}, Purchase Price : {purchasePrice}, Sale Price : {salePrice}, Discount : {discount}";
        }
    }
}
