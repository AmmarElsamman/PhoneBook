using Spectre.Console;

namespace PhoneBook.EntityFramework;

internal class Program
{
    static void Main(string[] args)
    {
        bool isAppRunning = true;

        while (isAppRunning)
        {
            var option = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOption>()
                .Title("Choose an option")
                .AddChoices(
                    MenuOption.AddContact,
                    MenuOption.DeleteContact,
                    MenuOption.UpdateContact,
                    MenuOption.ViewContacts,
                    MenuOption.Quit));


            switch (option)
            {
                case MenuOption.AddContact:

                    ContactController.AddContact();
                    break;
                case MenuOption.DeleteContact:
                    ContactServices.DeleteContact();
                    break;
                case MenuOption.UpdateContact:
                    ContactController.UpdateContact();
                    break;
                case MenuOption.ViewContacts:
                    var contacts = ContactController.GetContacts();
                    UserInterface.ShowContactTable(contacts);
                    break;
                case MenuOption.Quit:
                    break;
            }

        }
    }


    enum MenuOption
    {
        AddContact,
        DeleteContact,
        UpdateContact,
        ViewContacts,
        Quit
    }
}