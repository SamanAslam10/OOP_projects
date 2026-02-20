using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._3._0.Customer
{
    internal class CustomerModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phoneNumber {  get; set; }
        public int age {  get; set; }
        public string address {  get; set; }

        public CustomerModel() { }
        public CustomerModel(int id,string name, string phoneNumber, int age, string address)
        {
            this.Id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.address = address;
        }
        public override string ToString()
        {
            return $"ID : {Id} ,Name : {name}, Contact : {phoneNumber}, Age : {age}, Address : {address}";
        }
    }
}