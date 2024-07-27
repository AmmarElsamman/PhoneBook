using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PhoneBook;

internal class Validator
{
    internal static bool IsEmailValid(string? email)
    {
        if (String.IsNullOrEmpty(email))
            return false;



        try
        {
            var emailAddress = new MailAddress(email);
        }
        catch
        {
            return false;
        }

        return true;

    }

    internal static bool IsPhoneNumberValid(string? phoneNumber)
    {
        if (String.IsNullOrEmpty(phoneNumber))
        {
            return false;
        }

        return Regex.Match(phoneNumber, @"^(\+[0-9]{12})$").Success;


    }
}
