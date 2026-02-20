using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat("Bella"));
            animals.Add(new Dog("Benny"));

            while (true) 
            {
                foreach (var a in animals) 
                {
                    Console.WriteLine(a.ToString());
                    Cat cat = new Cat();
                    cat.Greets();
                    Dog dog = new Dog();
                    dog.Greets();
                    Dog dog2 = new Dog("Blanco");
                    dog.Greets(dog2);
                }
                Console.ReadKey();
            }
        }
    }
}
