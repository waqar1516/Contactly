using Contactly.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contactly.Data
{
    public class ContactlyDBContext : DbContext
    {
        public ContactlyDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
