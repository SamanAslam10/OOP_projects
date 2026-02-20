using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum number of order : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum price of order : ");
            int y = int.Parse(Console.ReadLine());

            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\week1\\week1tasks\\week1tasks\\task13.txt";
            StreamReader customer = new StreamReader(path);
            string record;
            while ((record = customer.ReadLine()) != null)
            {
                string[] parts = record.Split(' ');
                string name = parts[0];
                int orders = int.Parse(parts[1]);
                List<int> prices = new List<int>();
                for (int i = 2; i < parts.Length; i++)
                {
                    string clean = parts[i].Replace("(" , "").Replace(")" , ""); 
                    prices.Add(int.Parse(clean));
                }
                int count = 0;
                foreach (int p in prices)
                {
                    if (p >= y)
                        count++;
                }

                if (count >= n)
                {
                    Console.WriteLine(name + " is eligible for a FREE pizza!");
                }

            }

        }
    }
}
