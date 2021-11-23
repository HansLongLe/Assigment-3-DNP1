using System.IO;
using Microsoft.EntityFrameworkCore;
using Server.Data.Models;

namespace Server.Data.DataAccess
{
    public class Assigment3DbContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Job { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = " + Path.GetFullPath(@"Database\Assigment3.db"));
        }

    }
}