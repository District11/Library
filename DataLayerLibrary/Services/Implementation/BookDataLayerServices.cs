using DataLayerLibrary;
using DataLayerLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Implementation
{
    public class BookDataLayerServices : IBookDataLayerServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public BookDataLayerServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public async Task AddBook(Book book)
        {
            await _libraryDBContext.AddAsync(book);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteBook(Book book)
        {
            _libraryDBContext.Entry(book).State = EntityState.Deleted;
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _libraryDBContext.Books.ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            return await _libraryDBContext.Books.AsQueryable().Where(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
