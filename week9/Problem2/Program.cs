using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Student("Saman", "Lahore" , "CS" , 2025 , 1000000));
            personList.Add(new Student("Amina", "Lahore", "PharmD", 2025, 1040000));

            personList.Add(new Staff("Ali", "Lahore", "Cathedral", 2000000));
            personList.Add(new Staff("Zakria", "Lahore", "LGS", 30000000));

            while (true) 
            {
                foreach (Person p in personList) 
                {
                    Console.WriteLine(p.ToString());
                }
                Console.ReadKey();
            }
        }
    }
}
