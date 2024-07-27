using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;
using Spectre.Console;

namespace PhoneBook
{
    internal class ContactController
    {
        internal static void AddContact()
        {
            var name = AnsiConsole.Ask<string>("Contact's name:");

            var email = AnsiConsole.Ask<string>("Contact's email (format: example@example.com): ");
            while (!Validator.IsEmailValid(email))
            {
                Console.WriteLine("Invalid Email!");
                email = Console.ReadLine();
            }

            var phoneNumber = AnsiConsole.Ask<string>("Contact's phone number (format: +012345678901):");
            while (!Validator.IsPhoneNumberValid(phoneNumber))
            {
                Console.WriteLine("Invalid Phone Number!");
                phoneNumber = Console.ReadLine();
            }

            var relationships = ContactController.GetRelationships();
            var relationshipsArray = relationships.Select(x => x.name).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("Choose Relation")
                .AddChoices(relationshipsArray));

            var selectedRelation = relationships.Single(r => r.name == option);


            using var db = new ApplicationContext();
            var relationFromDb = db.Relationships.SingleOrDefault(r => r.Id == selectedRelation.Id);

            var contact = new Contact { Name = name, Email = email, PhoneNumber = phoneNumber, Relationship = relationFromDb };

            db.Add(contact);
            db.SaveChanges();

            Console.Clear();

        }

        internal static void DeleteContact(Contact contact)
        {
            using var db = new ApplicationContext();
            db.Remove(contact);

            db.SaveChanges();
        }

        internal static void UpdateContact()
        {
            throw new NotImplementedException();
        }

        internal static List<Contact> GetContacts()
        {
            using var db = new ApplicationContext();

            var contacts = db.Contacts.Include(r => r.Relationship).ToList<Contact>();

            return contacts;
        }

        internal static List<Relationship> GetRelationships()
        {
            using var db = new ApplicationContext();

            var relationships = db.Relationships.ToList<Relationship>();

            return relationships;
        }

    }
}
