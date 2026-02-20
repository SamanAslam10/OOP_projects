using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace week_2_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Ali Hamza";
            int id1 = 24;
            float gpa1 = 3.6F;
            Student s1 = new Student(id1 , name1 , gpa1);

            string name2 = "Saman Aslam";
            int id2 = 30;
            float gpa2 = 4.0F;
            Student s2 = new Student(id2, name2, gpa2);

            string name3 = "Amina Amjad";
            int id3 = 26;
            float gpa3 = 3.7F;
            Student s3 = new Student(id3, name3, gpa3);

            string name4 = "Manahil Khan";
            int id4 = 20;
            float gpa4 = 3.2F;
            Student s4 = new Student(id4, name4, gpa4);

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);


            while (true) 
            {
                int option = Option();
                if(option == 1)
                {
                    foreach(Student s in students) 
                    {
                        s.DisplayDetails();
                    }
                }
                if (option == 2)
                {
                    foreach (Student s in students) 
                    {
                        s.UpdateGPA(students);
                        break;
                    }
                }
                if(option == 3) 
                {
                   foreach (Student s in students) 
                    {
                        s.HonorRollCheck(students);
                        break;
                    }
                }
            }

        }
        static int Option()
        {
            Console.WriteLine("Choose Option from below : ");
            Console.WriteLine("1. Display all Students ");
            Console.WriteLine("2. Update the GPA");
            Console.WriteLine("3. Honor Roll Check");

            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
    class Student 
    {
        public int studentID;
        public string name;
        public float GPA;

        public Student() 
        {
        }
        public Student(int id, string stname , float gpa) 
        {
            studentID = id;
            name = stname;
            GPA = gpa;
        }
        public void DisplayDetails()
        {
            Console.WriteLine( studentID + " " + name + " " + GPA);
        }
        public void HonorRollCheck(List<Student>students) 
        {
            foreach (Student s in students) 
            {
                if(s.GPA >= 3.5) 
                {
                    Console.WriteLine(s.studentID + " " + s.name + " " + s.GPA);
                }
            }
        }
        public void UpdateGPA(List<Student>students) 
        {
            Console.Write("Enter the student ID whom you want to update GPA of : ");
            int updateID =int.Parse(Console.ReadLine());
            Console.Write("Enter the updated GPA  : ");
            float updategpa = float.Parse(Console.ReadLine());
            foreach (Student s in students) 
            {
                if (s.studentID == updateID) 
                {
                    s.GPA = updategpa;
                    Console.WriteLine("GPA is updated ");
                    break;
                }
            }
        }
    }
}