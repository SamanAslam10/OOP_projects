using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title;
        public List<string> author = new List<string>();
        public int AuthorCount = 0;
        public string publisher;
        public int ISBN;
        public float price;
        public int copies;
        public string yearofPublication;

        public Book(string title, List<string> author, int authorCount, string publisher, int ISBN, float price, int stock, string yearofPublication)
        {
            this.title = title;
            this.author = author;
            AuthorCount = authorCount;
            this.publisher = publisher;
            this.ISBN = ISBN;
            this.price = price;
            this.copies = copies;
            this.yearofPublication = yearofPublication;
        }
        public string GetTitle() 
        {
            return title;
        }
        public void SetTitle(string title) 
        {
            this.title = title;
        }
        public void CheckTitle() { }
        public void ShowCopies() { }
        public void SetCopies(int copies) { }
        public void UpdateCopies() { }
        public int ReturnCopies() 
        {
            return 1;
        }
        public void ShowAuthor()
        {

        }
        public void SetAuthor() { }
        public void CheckAuthor() { }
        public void SetISBN(int ISBN)
        {
            this.ISBN = ISBN;
        }
        public void SearchbyISBN() { }
        public string GetPublisher()
        {
            return publisher;
        }
        public void SetPublisher(string publisher) 
        {
            this.publisher = publisher;
        }
        public void CheckPublisher() { }
        public float Getprice()
        {
            return price;
        }
        public void Setprice(float price) 
        {
            this.price = price;
        }
        public void Checkprice() { }

    }
}
