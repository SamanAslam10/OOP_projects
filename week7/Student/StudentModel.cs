using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public float CGPA { get; set; }

        public StudentModel(int Id , string Name , int age , string Address , float CGPA) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = age;
            this.Address = Address;
            this.CGPA = CGPA;
        }
        public StudentModel(string Name, int age, string Address, float CGPA)
        {
            this.Name = Name;
            this.Age = age;
            this.Address = Address;
            this.CGPA = CGPA;
        }
    }
}
