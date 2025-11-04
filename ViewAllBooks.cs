public static void ViewBooks()
{
    using var db = new LibraryContext();
    var books = db.Books.ToList();

    Console.WriteLine("\nID | Title | Author | Copies");
    Console.WriteLine("-----------------------------------------");
    foreach (var b in books)
    {
        Console.WriteLine($"{b.Id} | {b.Title} | {b.Author} | {b.CopiesAvailable}");
    }
    Console.WriteLine();
}
