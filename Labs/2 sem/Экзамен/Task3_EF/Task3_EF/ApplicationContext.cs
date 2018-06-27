using System.Data.Entity;
using Task3_EF.Models;

namespace Task3_EF
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}