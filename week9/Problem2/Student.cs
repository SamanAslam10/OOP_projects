using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Student : Person
    {
        public string program { get; set; }
        public int year { get; set; }
        public double fee { get; set; }

        public Student(string name , string address ,string program, int year, double fee) : base(name , address) 
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public override string ToString() 
        {
            return $"Student {name} , {address} , {program} , {year} , {fee}";
        }
    }
}
