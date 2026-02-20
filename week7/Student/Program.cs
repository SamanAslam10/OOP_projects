using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepoDB db = new StudentRepoDB();
            StudentModel student1 = new StudentModel("Ali", 20, "Lahore", 3);
            db.Create(student1);
            StudentModel student2 = new StudentModel("Saman", 19, "Lahore", 4);
            db.Create(student2);
            StudentModel student3 = new StudentModel("Amina", 19, "Lahore", 4);
            db.Create(student3);

            StudentModel student4 = new StudentModel("Ali", 21, "Lahore", 3);

            db.Update(student4 , 4);
            db.Delete(1);

            List<StudentModel> studentsList = new List<StudentModel>();
            studentsList = db.GetStudents();
            foreach (StudentModel student in studentsList) 
            {
                Console.WriteLine(student.Name, student.Age, student.Address , student.CGPA);
            }
        }
    }
}