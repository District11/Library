using DataLayerLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayerLibrary
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext() { }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }


        public LibraryDBContext(DbContextOptions options) : base(options) {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Book>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Publisher>()
                .HasKey(p => p.Id);
        }
    }
}
