using Lab_8.Models;
using System.Data.Entity;

namespace Lab_8
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection")
        {
        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<Zoo> Zoos { get; set; }
    }
}