using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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
            int id1 = 1009;
            string title1 = "White Nights";
            string author1 = "F. Deosteovsky";
            int id2 = 1008;
            string title2 = "Metamorphosis";
            string author2 = "Franz Kafka";
            int id3 = 1007;
            string title3 = "Norweign Woods";
            string author3 = "Haruki Murakami";
            Book b1 = new Book( id1 , title1 , author1);
            Book b2 = new Book(id2, title2, author2);
            Book b3 = new Book(id3, title3, author3);
            

            List<Book> booksList = new List<Book>();
            booksList.Add(b1);
            booksList.Add(b2);
            booksList.Add(b3);

            while (true) 
            {
                int option = Option();
                if (option == 1)
                {
                    Console.Write("Enter the ID of new book");
                    int newid = int.Parse(Console.ReadLine());
                    Console.Write("Enter the title of new book");
                    string newtitle = Console.ReadLine();
                    Console.Write("Enter the author of new book");
                    string newauthor = Console.ReadLine();
                    Book newbook = new Book(newid, newtitle, newauthor);
                    booksList.Add(newbook);
                }
                if (option == 2)
                {
                    foreach(Book b in booksList) 
                    {
                        b.Displaybooks();
                    }
                }
                if (option == 3)
                {
                    Console.Write("Enter the ID of book you want to remove : ");
                    int id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < booksList.Count(); i++)
                    {
                        if (booksList[i].bookID == id)
                        {
                            booksList.RemoveAt(i);
                        }
                    }
                }
            
            }
        }
        static int Option() 
        {
            Console.WriteLine("Choose Option from below : ");
            Console.WriteLine("1. Add a new BOOK ");
            Console.WriteLine("2. Display all Books");
            Console.WriteLine("3. Remove a Book");

            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
    public class Book 
    {
        public int bookID;
        public string title;
        public string author;

        public Book(int bookID, string title, string author)
        {
            this.bookID = bookID;
            this.title = title;
            this.author = author;
        }
        public void Displaybooks() 
        {
            Console.WriteLine(bookID + " " + title + " " + author);
            
        }
    
    }
}