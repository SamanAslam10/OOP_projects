using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Person
    {
        public string name;
        public string address;

        public Person(string name, string address) 
        {
            this.name = name;
            this.address = address;
        }
        public string getName() 
        {
            return name;
        }
        public string getAddress() 
        {
            return address;
        }
        public void setAddress(string address) 
        {
            this.address = address;
        }
        public override string ToString() 
        {
            return $"Person[Name = {name}  , address] {address}";
        }
    }
}
