using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Cat : Mammal
    {
        public Cat() { }
        public Cat(string name) : base(name) { }
        public void Greets() 
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            return $"Cat{name}";
        }
    }
}
