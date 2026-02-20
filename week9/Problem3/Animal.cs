using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Animal
    {
        public Animal() { }
        protected string name {  get; set; }

        public Animal(string name) 
        {
            this.name = name;
        }
        public override string ToString() 
        {
            return $"Name{name}";
        }
    }
}
