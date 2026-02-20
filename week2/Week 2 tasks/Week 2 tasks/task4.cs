using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id1 = 1;
            string model1 = "Honda Civic 2025";
            float price1 = 1000000F;
            Car c1 = new Car(id1 ,model1,price1);

            int id2 = 2;
            string model2 = "Audi 2024";
            float price2 = 2000000F;
            Car c2 = new Car(id2, model2, price2);

            int id3 = 3;
            string model3 = "BMW 2025";
            float price3 = 3000000F;
            Car c3 = new Car(id3, model3, price3);

            List<Car> carsList = new List<Car>();
            carsList.Add(c1);
            carsList.Add(c2);
            carsList.Add(c3);

            while (true) 
            {
                int option = menu();
                if (option == 1) 
                {
                    Console.Write("Enter Car ID : ");
                    int newid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Car Model : ");
                    string newmodel = Console.ReadLine();
                    Console.Write("Enter Car price : ");
                    float newprice = float.Parse(Console.ReadLine());

                    Car newp = new Car(newid, newmodel, newprice);
                    carsList.Add(newp);
                }
                if (option == 2)
                {
                    for (int i = 0; i < carsList.Count; i++)
                    {
                        Console.WriteLine(carsList[i].CarID + " " + carsList[i].CarModel + " " + carsList[i].CarPrice);
                    }
                }
                if (option == 3) 
                {
                    float mostexpensive = carsList[0].CarPrice;
                    int a = 0;
                    for (int i = 0; i < carsList.Count; i++) 
                    {
                        if (carsList[i].CarPrice > mostexpensive) 
                        {
                            mostexpensive = carsList[i].CarPrice;
                            a = i;
                        }
                    }
                    Console.WriteLine("The Details of Most Expensive Car are : ");
                    Console.WriteLine(carsList[a].CarID + " " + carsList[a].CarModel + " " + carsList[a].CarPrice);
                }
            }
        }
        static int menu()
        {
            Console.WriteLine("Choose one option : ");
            Console.WriteLine("1.Add New Car");
            Console.WriteLine("2.View All Cars");
            Console.WriteLine("3.Find Most Expensive Car");
         
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class Car
    {
        public int CarID;
        public string CarModel;
        public float CarPrice;

        public Car(int ID, string model, float Price)
        {
            CarID = ID;
            CarModel = model;
            CarPrice = Price;
        }

    }
}