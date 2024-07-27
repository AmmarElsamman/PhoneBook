using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Relationship> Relationships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Contact;Trusted_Connection=True;");

    }
}
