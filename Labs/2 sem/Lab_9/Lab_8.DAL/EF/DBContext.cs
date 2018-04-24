using Lab_8.DAL.Entities;
using System.Data.Entity;

namespace Lab_8.DAL.EF
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Animals> Animals { get; set; }
    }
}