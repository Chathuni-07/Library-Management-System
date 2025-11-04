using LibrarySystem.Data;
using LibrarySystem.Models;

public static class BookOperations
{
    public static void AddBook()
    {
        using var db = new LibraryContext();
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine()!;
        Console.Write("Enter Author: ");
        string author = Console.ReadLine()!;
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine()!;
        Console.Write("Copies Available: ");
        int copies = int.Parse(Console.ReadLine()!);

        var book = new Book { Title = title, Author = author, ISBN = isbn, CopiesAvailable = copies };
        db.Books.Add(book);
        db.SaveChanges();
        Console.WriteLine("✅ Book added successfully!");
    }
}
