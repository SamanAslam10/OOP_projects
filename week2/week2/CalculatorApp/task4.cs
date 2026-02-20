using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            int scount = 0;
            while(true)
            {

                Console.WriteLine("Choose Option : ");
                Console.WriteLine("1.Add Students ");
                Console.WriteLine("2.Show Students ");
                Console.WriteLine("3.Calculate Aggregate ");
                Console.WriteLine("4.Top Students ");
                int option = int.Parse(Console.ReadLine());
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
                    Student sts[scount] = new Student(name , matric , fsc , ecat );
                    scount++;
                }
            }
           

        }

    }

    class Student
    {
        public string name;
        public float matric;
        public float fsc;
        public float ecat;

        public Student(string nameU , float matricU , float fscU , float ecatU) 
        {
        }

     
    }
}
