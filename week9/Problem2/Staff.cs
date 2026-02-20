using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Staff : Person
    {
        public string school {  get; set; }
        public double pay {  get; set; }

        public Staff (string name , string address ,string school, double pay) : base(name , address) 
        {
            this.school = school;
            this.pay = pay;
        }
        public override string ToString() 
        {
            return $"Staff {name} , {address} , {school} , {pay}";
        }
    }
}
