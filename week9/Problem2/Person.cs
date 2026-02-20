using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Person
    {
        protected string name { get; set; }
        protected string address { get; set; }

        public Person(string name , string address) 
        {
            this.name = name;
            this.address = address;
        }
        public override string ToString()
        {
            return $"{name} , {address}";
        }
    }
}
