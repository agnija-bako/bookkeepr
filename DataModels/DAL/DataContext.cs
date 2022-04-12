using DataModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DataModels.DAL
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Purchase> Purchase { get; set; }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=192.168.0.124;Database=bookkeepr;Uid=myuser;Pwd=Agnija21");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Genre>().ToTable("Genres");
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Library>().ToTable("Libraries");
            modelBuilder.Entity<Purchase>().ToTable("Purchase");
        }
    }
}
