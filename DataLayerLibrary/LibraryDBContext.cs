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
            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.AuthorId, ab.BookId });

            modelBuilder.Entity<AuthorBook>()
                .HasOne(b => b.Book)
                .WithMany()
                .HasForeignKey(ab =>ab.BookId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<Book>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Publisher>()
                .HasMany(b => b.Books).
                WithOne();
        }
    }
}
