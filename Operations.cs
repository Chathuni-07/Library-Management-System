using LibrarySystem.Data;

class Program
{
    static void Main()
    {
        using var db = new LibraryContext();
        db.Database.EnsureCreated();

        while (true)
        {
            Console.WriteLine("\n=== Library Menu ===");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Add Member");
            Console.WriteLine("4. Lend Book");
            Console.WriteLine("5. Return Book");
            Console.WriteLine("6. View Active Loans");
            Console.WriteLine("7. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1": BookOperations.AddBook(); break;
                case "2": BookOperations.ViewBooks(); break;
                case "3": MemberOperations.AddMember(); break;
                case "4": BookOperations.LendBook(); break;
                case "5": BookOperations.ReturnBook(); break;
                case "6": BookOperations.ViewActiveLoans(); break;
                case "7": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}
