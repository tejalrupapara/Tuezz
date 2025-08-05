using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuezz
{
    class Book
    {
        // Members
        public int bookId;
        public string bookTitle;
        public string bookAuthor;
        public double bookPrice;

        // Default Constructor
        public Book()
        {
            bookId = 0;
            bookTitle = "";
            bookAuthor = "";
            bookPrice = 0.0;
        }

        // Method to set book details
        public void SetBookDetails(int id, string title, string author, double price)
        {
            bookId = id;
            bookTitle = title;
            bookAuthor = author;
            bookPrice = price;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Title: " + bookTitle);
            Console.WriteLine("Author: " + bookAuthor);
            Console.WriteLine("Price: ₹" + bookPrice);
            Console.WriteLine("****************************");
        }
    }

    class library
    {
        static void Main(String[]args)
        {
            
            Book[] books = new Book[5];

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book();
            }

            
            books[0].SetBookDetails(101, "C# Programming", "John Doe", 499.99);
            books[1].SetBookDetails(102, "Data Structures", "Alice Brown", 359.50);
            books[2].SetBookDetails(103, "AI Basics", "Andrew Ng", 899.75);
            books[3].SetBookDetails(104, "DBMS Concepts", "Elmasri", 699.00);
            books[4].SetBookDetails(105, "Networking Essentials", "James Kurose", 450.25);

           
            Console.WriteLine("Book Details:");
            Console.WriteLine("===========================");
            foreach (Book book in books)
            {
                book.Display();
            }
        }
    }
}
