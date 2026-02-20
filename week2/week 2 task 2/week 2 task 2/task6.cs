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
            string title1 = "White Nights";
            string author1 = "F. Deostevosky";
            Book b1 = new Book(title1 , author1);

            string title2 = "The Trial";
            string author2 = "Franz Kafka";
            Book b2 = new Book(title2 , author2);

            string title3 = "Honor";
            string author3 = "Elif Shafak";
            Book b3 = new Book(title3 , author3);

            List<Book> books = new List<Book>();
            books.Add(b1);
            books.Add(b2);
            books.Add(b3);

            while (true) 
            {
                int option = Option();
                if(option == 1)
                {
                    foreach (Book b in books)
                    {
                        b.Displaybooks();
                    }
                }
                if (option == 2)
                {
                    foreach(Book b in books) 
                    {
                        b.UpdatePrice(books);
                    }
                }
                if(option == 3) 
                {
                    foreach(Book b in books) 
                    {
                        b.CheckBookAuthor(books);
                    }
                }
            }

        }
        static int Option()
        {
            Console.WriteLine("Choose Option from below : ");
            Console.WriteLine("1. Display all Books ");
            Console.WriteLine("2. Update the price");
            Console.WriteLine("3. Check the Author");

            int option = int.Parse(Console.ReadLine());
            return option;

        }
    }
    class Book 
    {
        public string title;
        public string author;
        public float price;

        public Book() 
        {

        }
        public Book(string title, string author) 
        {
            this.title = title;
            this.author = author;
        }
        public void Displaybooks()
        {
            Console.WriteLine( title + " " + author);

        }
        public void CheckBookAuthor(List<Book>books) 
        {
            Console.Write("Enter the name of author : ");
            string authorName = Console.ReadLine();
            foreach (Book b in books) 
            {
                if (authorName == b.author)
                {
                    Console.WriteLine("YES! " + b.title + " is written by " + b.author);
                    break;
                }
            }
            
        }
        public void UpdatePrice(List<Book> books) 
        {
            Console.Write("Enter the name of book you want to update the price of : ");
            string bookname = Console.ReadLine();
            foreach(Book b in books) 
            {
                if (bookname == b.title)
                {
                    Console.Write("Enter the updated Price : ");
                    float updatedprice = float.Parse(Console.ReadLine());
                    b.price = updatedprice;
                    Console.WriteLine("Price of " + b.title + " is updated!");
                    break;
                }
            }
            
        }

    }
}
