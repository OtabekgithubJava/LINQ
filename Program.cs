using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp3.Model;

class Program
{
    static void Main()
    {
        List<Programmer> programmers = new List<Programmer>
        {
            new Programmer { Name = "John", Age = 28, ProgrammingLanguage = "C#", Email = "john@example.com", PhoneNumber = "123-456-7890" },
            new Programmer { Name = "Alice", Age = 35, ProgrammingLanguage = "Java", Email = "alice@example.com", PhoneNumber = "987-654-3210" },
            new Programmer { Name = "Bob", Age = 30, ProgrammingLanguage = "Python", Email = "bob@example.com", PhoneNumber = "555-555-5555" },
            new Programmer { Name = "Eva", Age = 25, ProgrammingLanguage = "JavaScript", Email = "eva@example.com", PhoneNumber = "111-222-3333" },
            new Programmer { Name = "Mike", Age = 32, ProgrammingLanguage = "C#", Email = "mike@example.com", PhoneNumber = "444-444-4444" }
        };
        
        List<Accountant> accountants = new List<Accountant>
        {
            new Accountant { Name = "Sarah", Age = 30, AccountingSoftware = "QuickBooks", Email = "sarah@example.com", PhoneNumber = "777-888-9999" },
            new Accountant { Name = "Tom", Age = 28, AccountingSoftware = "Xero", Email = "tom@example.com", PhoneNumber = "666-666-6666" },
            new Accountant { Name = "Emma", Age = 35, AccountingSoftware = "Sage", Email = "emma@example.com", PhoneNumber = "123-987-5678" },
            new Accountant { Name = "Chris", Age = 32, AccountingSoftware = "Wave", Email = "chris@example.com", PhoneNumber = "111-333-5555" },
            new Accountant { Name = "Olivia", Age = 26, AccountingSoftware = "FreshBooks", Email = "olivia@example.com", PhoneNumber = "999-111-2222" }
        };
        
        var cSharpProgrammers = programmers.Where(p => p.ProgrammingLanguage == "C#");
        Console.WriteLine("Programmers who know C#:");
        foreach (var programmer in cSharpProgrammers)
        {
            Console.WriteLine($"Name: {programmer.Name}, Age: {programmer.Age}, Email: {programmer.Email}, Phone: {programmer.PhoneNumber}");
        }
        
    }
}
