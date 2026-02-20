using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Dog : Mammal
    {
        public Dog() { }
        public Dog(string name) : base(name) { }
        public void Greets() 
        {
            Console.WriteLine("woooof");
        }
        public void Greets(Dog another) 
        {
            Console.WriteLine("wooof wooof");
        }
        public override string ToString() 
        {
            return $"Dog{name}";
        }
    }
}
