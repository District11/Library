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

        public DbSet<AuthorBook> AuthorBooks { get; set; }

        public LibraryDBContext(DbContextOptions options) : base(options) {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
                .HasKey(ab => new { ab.BookId, ab. AuthorId });

            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Author)
                .WithMany(a => a.ListBooks)
                .HasForeignKey(ab =>ab.AuthorId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(ab => ab.Book)
                .WithMany(b => b.ListAuthor)
                .HasForeignKey(ab => ab.BookId);

            modelBuilder.Entity<Author>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Book>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Publisher>()
                .HasMany(b => b.Books).
                WithOne(p =>p.Publisher);
        }
    }
}
