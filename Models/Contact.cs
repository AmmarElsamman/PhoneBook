using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Models
{


    [Index(nameof(Name), nameof(Email), nameof(PhoneNumber), IsUnique = true)]
    internal class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Relationship Relationship { get; set; }
    }
}
