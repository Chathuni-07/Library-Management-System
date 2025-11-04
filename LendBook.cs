public static void LendBook()
{
    using var db = new LibraryContext();
    Console.Write("Enter Member ID: ");
    int memberId = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Book ID: ");
    int bookId = int.Parse(Console.ReadLine()!);

    var book = db.Books.Find(bookId);
    if (book == null || book.CopiesAvailable <= 0)
    {
        Console.WriteLine(" Book not available.");
        return;
    }

    var loan = new Loan
    {
        BookId = bookId,
        MemberId = memberId,
        LoanDate = DateTime.Now
    };

    book.CopiesAvailable--;
    db.Loans.Add(loan);
    db.SaveChanges();
    Console.WriteLine(" Book lent successfully!");
}
