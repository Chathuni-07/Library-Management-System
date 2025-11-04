public static void ReturnBook()
{
    using var db = new LibraryContext();
    Console.Write("Enter Loan ID: ");
    int loanId = int.Parse(Console.ReadLine()!);

    var loan = db.Loans.FirstOrDefault(l => l.Id == loanId && l.ReturnDate == null);
    if (loan == null)
    {
        Console.WriteLine(" Loan not found or already returned.");
        return;
    }

    var book = db.Books.Find(loan.BookId);
    if (book != null) book.CopiesAvailable++;

    loan.ReturnDate = DateTime.Now;
    db.SaveChanges();
    Console.WriteLine(" Book returned successfully!");
}
