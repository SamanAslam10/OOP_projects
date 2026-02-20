using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books= new List<Book>();
            while (true) 
            {
                int option = Menu();
                if (option == 1)
                {
                    Book book1 = new Book("Pride and Prejudice", "Jane Auston", 1813, 19.99, 10);
                    Book book2 = new Book("Hamlet", "William Shakespeare", 1603, 15.50, 10);
                    Book book3 = new Book("War and Peace", "Leo Tolstoy", 1869, 25.99, 10);
                    books.Add(book1);
                    books.Add(book2);
                    books.Add(book3);
                }
                else if (option == 2)
                {
                    foreach (Book book in books)
                    {
                        book.BookDetails(books);
                        break;
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter the title of Book : ");
                    string title = Console.ReadLine();
                    foreach (Book b in books)
                    {
                        if (b.title == title)
                        {
                            Console.WriteLine("The Author of Book " + b.title + " is " + b.author);
                        }
                    }
                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter the title of Book : ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter the Sell Copies : ");
                    int noOFcopies = int.Parse(Console.ReadLine());
                    foreach (Book b in books)
                    {
                        b.SellCopies(noOFcopies);
                    }
                }
                else if (option == 5) 
                {
                    Console.WriteLine("Enter the title of Book : ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter the ReStock Quantity : ");
                    int restock = int.Parse(Console.ReadLine());
                    foreach (Book b in books)
                    {
                        b.ReStock(restock);
                    }
                }
                else if (option == 6)
                {
                    int bookscount = 0;
                    foreach(Book book in books) 
                    {
                        bookscount++;
                    }
                    Console.WriteLine("The Books in Book List is : " + bookscount);
                }
                else if (option == 7)
                {
                    Console.WriteLine("Exiting the Program!");
                    break;
                }
            }
        }
        static int Menu()
        {
            Console.WriteLine("Choose from Menu : ");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All the Books Information");
            Console.WriteLine("3. Get the Author details");
            Console.WriteLine("4. Sell Copies");
            Console.WriteLine("5. Restock a Book");
            Console.WriteLine("6. Books Count");
            Console.WriteLine("7. Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class Book
    {
        public string title;
        public string author;
        public int publicationYear;
        public double price;
        public int QuantityInStock;

        public Book(string title , string author , int publicationYear , double price , int QuantityInStock) 
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.price = price;
            this.QuantityInStock = QuantityInStock;
        }
        public string getTitle() 
        {
            return "Title : " + title;
        }
        public string getAuthor()
        {
            return "Author : " + author;
        }
        public string getPublicationYear()
        {
            return "Publication Year : " + publicationYear ;
        }
        public string getPrice()
        {
            return "Price : " + price;
        }
        public void SellCopies( int noOFcopies)
        {
            if(noOFcopies < QuantityInStock) 
            {
                QuantityInStock = QuantityInStock - noOFcopies;

            }
            else 
            {
                Console.WriteLine("Not Enough Copies!");
            }
        }
        public void ReStock(int additionalCopies) 
        {
            QuantityInStock += additionalCopies;
        }
        public void BookDetails(List<Book>books) 
        {
            foreach(Book b in books) 
            {
                Console.WriteLine("Title : " + b.title + " Author " + b.author + " Publication Year : " + b.publicationYear + " Price : " + b.price);
            }
        }
    }
}