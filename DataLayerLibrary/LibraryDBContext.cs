using DataLayerLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayerLibrary
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public LibraryDBContext(DbContextOptions options) : base(options) { }

    }
}
