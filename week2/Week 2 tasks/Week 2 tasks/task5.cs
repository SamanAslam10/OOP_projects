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
            string title1 = "Enola Holmes";
            float duration1 = 2.5F;
            Movie m1 = new Movie(id1 ,title1,duration1);

            int id2 = 2;
            string title2 = "Mouse";
            float duration2 = 3.5F;
            Movie m2= new Movie(id2, title2, duration2);

            int id3 = 3;
            string title3 = "Conjuring";
            float duration3 = 3F;
            Movie m3 = new Movie(id3, title3, duration3);

            List<Movie> moviesList = new List<Movie>();
            moviesList.Add(m1);
            moviesList.Add(m2);
            moviesList.Add(m3);

            while (true) 
            {
                int option = menu();
                if (option == 1) 
                {
                    Console.Write("Enter Movie ID : ");
                    int newid = int.Parse(Console.ReadLine());
                    Console.Write("Enter Movie Title : ");
                    string newtitle = Console.ReadLine();
                    Console.Write("Enter Movie Duration : ");
                    float newduration = float.Parse(Console.ReadLine());

                    Movie newM = new Movie(newid, newtitle, newduration);
                    moviesList.Add(newM);
                }
                if (option == 2)
                {
                    for (int i = 0; i < moviesList.Count; i++)
                    {
                        Console.WriteLine(moviesList[i].MovieID + " " + moviesList[i].Title + " " + moviesList[i].Duration);
                    }
                }
                if (option == 3) 
                {
                    Console.Write("Enter the title of Movie you want to search : ");
                    string searchtitle = Console.ReadLine();
                    for(int i = 0; i < moviesList.Count(); i++) 
                    {
                        if (moviesList[i].Title == searchtitle) 
                        {
                            Console.WriteLine(moviesList[i].MovieID + " " + moviesList[i].Title + " " + moviesList[i].Duration);
                        }
                    }
                }
            }
        }
        static int menu()
        {
            Console.WriteLine("Choose one option : ");
            Console.WriteLine("1.Add New Movies");
            Console.WriteLine("2.View All Movies");
            Console.WriteLine("3.Search");
         
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class Movie
    {
        public int MovieID;
        public string Title;
        public float Duration;

        public Movie(int ID, string title, float duration)
        {
            MovieID = ID;
            Title = title;
            Duration = duration;
        }
    }
}