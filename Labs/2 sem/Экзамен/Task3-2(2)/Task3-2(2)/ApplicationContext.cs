using System.Data.Entity;
using Task3_2_2_.Models;

namespace Task3_2_2_
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        { }

        public DbSet<Person> Persons { get; set; }
    }
}
