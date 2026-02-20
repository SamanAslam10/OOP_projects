using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                List<Student> students = new List<Student>();
                int option = Menu();
                if (option == 1)
                {
                    Console.WriteLine("Enter name of student : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the matric marks : ");
                    float matric = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the fsc marks : ");
                    float fsc = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the ecat marks : ");
                    float ecat = float.Parse(Console.ReadLine());
                    Student s = new Student(name, matric, fsc, ecat);
                    students.Add(s);
                }
                if (option == 2)
                {
                    foreach (Student s in students) 
                    {
                        s.DisplayStudents(students);
                        break;
                    }
                }
                if (option == 3)
                {
                    foreach(Student s in students) 
                    {
                        s.CalculateAggregate(students);
                        break ;
                    }
                }
                if (option == 4)
                {
                    
                }
            }
            
        }
        static int Menu() 
        {
            Console.WriteLine("Choose Option : ");
            Console.WriteLine("1.Add Students ");
            Console.WriteLine("2.Show Students ");
            Console.WriteLine("3.Calculate Aggregate ");
            Console.WriteLine("4.Top Students ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }

    class Student
    {
        public string name;
        public float matric;
        public float fsc;
        public float ecat;
        public float aggregate;

        public Student(string nameU, float matricU, float fscU, float ecatU)
        {
            this.name = nameU;
            this.matric = matricU;
            this.fsc = fscU;
            this.ecat = ecatU;
        }
        public void DisplayStudents(List<Student>students) 
        {
            foreach(Student s in students) 
            {
                Console.WriteLine(s.name + " " + s.matric + " " + s.fsc + " " + s.ecat);
            }
        }
        public void CalculateAggregate(List<Student> students) 
        {
            foreach (Student s in students) 
            {
                s.aggregate = (25 * s.matric /1100) + (45 * s.fsc/1100) + (3 * s.ecat/400);
                students.Add(s);
            }
            
        }
    
    }
}
