using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("2025(S)-CS-78", "Saman Aslam", "CS", 2, 90, 95, 100, 89, 94);
            student.TotalMarks();
            student.Average();
            student.Grade();
            student.ToString();    
        }
    }
    class Student 
    {
        public string id;
        public string name;
        public string department;
        public int semester;
        public float marks1;
        public float marks2;
        public float marks3;
        public float marks4;
        public float marks5;

        public Student() 
        { }

        public Student(string id, string name , string department , int semester , float marks1 , float marks2 , float marks3 , float marks4 , float marks5) 
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.semester = semester;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
            this.marks4 = marks4;
            this.marks5 = marks5;

        }

        public float TotalMarks() 
        {
            float total = marks1 + marks2 + marks3 + marks4 + marks5;
            return total;
        }
        public float Average() 
        {
            float avg = TotalMarks() / 5;
            return avg;
        }
        public string Grade()
        {
            string grade;
            if (Average() > 90)
            {
                grade = "A";
                return grade;
            }
            else if (Average() <= 90)
            {
                grade = "B";
                return grade;
            }
            else
            {
                grade = "F";
                return grade;
            }
        }
        public void ToString() 
        {
            Console.WriteLine(id + " " + name + " " + department + " " + semester + " " + marks1 + " " + marks2 + " " + marks3 + " " + marks4 + " " + marks5 + " Total Marks :  " + TotalMarks() + " Average Marks " + Average() + " Grade : " + Grade());
        }
    }
}
