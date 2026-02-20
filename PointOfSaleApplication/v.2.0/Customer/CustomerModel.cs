using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._2._0.Customer
{
    internal class CustomerModel
    {
            public string name;
            public string phoneNumber;
            public int age;
            public string address;

            public CustomerModel() { }
            public CustomerModel(string name, string phoneNumber, int age, string address)
            {
                this.name = name;
                this.phoneNumber = phoneNumber;
                this.age = age;
                this.address = address;
            }
            public void SetName(string name)
            {
                this.name = name;
            }
            public string GetName()
            {
                return this.name;
            }
            public void SetPhoneNumber(string phonenumber)
            {
                this.phoneNumber = phonenumber;
            }
            public string GetPhoneNumber()
            {
                return this.phoneNumber;
            }
            public void SetAge(int age)
            {
                this.age = age;
            }
            public int GetAge()
            {
                return this.age;
            }
            public void SetAddress(string address)
            {
                this.address = address;
            }
            public string GetAddress()
            {
                return this.address;
            }
            public override string ToString()
            {
                return $"Name : {name}, Contact : {phoneNumber}, Age : {age}, Address : {address}";
            }
    }
}
