using System;

class Book
{
    // Members (fields / properties)
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public double OriginalPrice { get; set; }
    public int Volume { get; set; }

    // Constructor
    public Book(int bookId, string title, string author, int pages, double originalPrice, int volume)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Pages = pages;
        OriginalPrice = originalPrice;
        Volume = volume;
    }

    // Method to calculate discount price
    public double GetDiscountPrice()
    {
        double discount = 0;

        if (Pages > 500)
            discount = 0.30;  // 30%
        else if (Pages > 300)
            discount = 0.20;  // 20%
        else
            discount = 0.10;  // 10%

        return OriginalPrice - (OriginalPrice * discount);
    }

    // Method to display book details
    public void ShowDetails()
    {
        Console.WriteLine("Book ID     : " + BookId);
        Console.WriteLine("Title       : " + Title);
        Console.WriteLine("Author      : " + Author);
        Console.WriteLine("Pages       : " + Pages);
        Console.WriteLine("Volume      : " + Volume);
        Console.WriteLine("Original Price : " + OriginalPrice);
        Console.WriteLine("Discounted Price : " + GetDiscountPrice());
        Console.WriteLine("----------------------------------");
    }
}

class Program1
{
    static void Main()
    {
        // Create multiple book objects
        Book b1 = new Book(101, "C# Basics", "Tejal", 250, 500, 1);
        Book b2 = new Book(102, "Advanced C#", "Rupapara", 350, 600, 2);
        Book b3 = new Book(103, "Mastering .NET", "Tejal Rupapara", 550, 1000, 3);

        // Store in array
        Book[] books = { b1, b2, b3 };

        // Find book with minimum discount price
        Book minBook = books[0];
        foreach (Book b in books)
        {
            if (b.GetDiscountPrice() < minBook.GetDiscountPrice())
                minBook = b;
        }

        Console.WriteLine("📘 Book with Lowest Discount Price:\n");
        minBook.ShowDetails();
    }
}
