using DataModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DataModels.DAL
{
    public class LibraryContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Purchase> Purchase { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=library;user=user;password=password");
        }


    }
}
