using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    public class Book
    {
        public double Price;
        public string Title;
        public string Author;
        public Book(double price, string title, string author) {
        Price = price;
        Title = title;
        Author = author;
        }

    }
            
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> 
            {
                new Book(20.9,"Book A", "Author 1"),
                new Book(25.99,"Book B", "Author 2"),
                new Book(15.45,"Book C", "Author 3"),
                new Book(27.3,"Book D", "Author 1"),
                new Book(10.3,"Book E", "Author 1")
            };
         
            IEnumerable<Book> filter = 
                from book in books
                where book.Author == "Author 1"
                orderby book.Price
                select book;

            Console.WriteLine("Books by Author 1, sorted by price:");
            foreach (var book in filter)
            {
                Console.WriteLine($"{book.Title} - ${book.Price}");
            }

        }

    }
}

