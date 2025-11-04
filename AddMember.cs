using LibrarySystem.Models;

public static class MemberOperations
{
    public static void AddMember()
    {
        using var db = new LibraryContext();
        Console.Write("Enter Member Name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter Email: ");
        string email = Console.ReadLine()!;

        var member = new Member { Name = name, Email = email };
        db.Members.Add(member);
        db.SaveChanges();
        Console.WriteLine("Member added successfully!");
    }
}
