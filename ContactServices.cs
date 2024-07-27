using PhoneBook.Models;
using Spectre.Console;

namespace PhoneBook
{
    internal class ContactServices
    {

        static internal Contact GetContactOptionInput()
        {
            var contacts = ContactController.GetContacts();
            var contactsArray = contacts.Select(c => c.Name).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("Choose Contact")
                .AddChoices(contactsArray));
            var id = contacts.Single(c => c.Name == option).Id;

            using var db = new ApplicationContext();
            var contact = db.Contacts.SingleOrDefault(r => r.Id == id);

            return contact;
        }



        static internal void DeleteContact()
        {
            var contact = GetContactOptionInput();
            ContactController.DeleteContact(contact);
        }



    }
}
