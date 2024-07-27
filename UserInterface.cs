using PhoneBook.Models;
using Spectre.Console;

namespace PhoneBook;

static internal class UserInterface
{
    static internal void ShowContactTable(List<Contact> Contacts)
    {
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Name");
        table.AddColumn("Email");
        table.AddColumn("Phone Number");
        table.AddColumn("Relationship");

        foreach (Contact contact in Contacts)
        {
            table.AddRow(contact.Id.ToString(), contact.Name, contact.Email, contact.PhoneNumber, contact.Relationship.name);
        }

        AnsiConsole.Write(table);

        Console.WriteLine("Press any key to continue\n");
        Console.ReadKey();
        Console.Clear();
    }


}
