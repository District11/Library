using DataLayerLibrary.Model;
using DataLayerLibrary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public async Task CreateBook(Book book)
        {
            foreach (var item in book.Authors)
            {
                _libraryDBContext.Entry(item).State = EntityState.Unchanged;
            }
            _libraryDBContext.Entry(book.Publisher).State = EntityState.Unchanged;
            await _libraryDBContext.AddAsync(book);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeleteBook(int id)
        {
            var findBook = await _libraryDBContext.Books.FindAsync(id);
            if (findBook != null)
            {
                _libraryDBContext.Remove(findBook);
                _libraryDBContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Невозможно удалить эту книгу!");
            }
        }

        public async Task<IEnumerable<Book>> GetAllBooks(int pageSize, int pageNumber, string filter, string sorted)
        {
            var sortmethod = Book.GetSortExpressions(sorted);
            if (filter == null)
            {
                return await _libraryDBContext.Books.Include(p => p.Authors).Include(p => p.Publisher)
               .Skip((pageNumber - 1) * pageSize)
               .Take(pageSize)
               .OrderBy(sortmethod)
               .ToListAsync();
            }
            else
            {
                return await _libraryDBContext.Books.Include(p => p.Authors).Include(p => p.Publisher)
                   .Where(t => t.Name.Contains(filter) ||t.Publisher.City.Contains(filter) 
                   || t.Authors.Any(a => a.LastName.Contains(filter)) || t.Authors.Any(a =>a.MiddleName.Contains(filter))
                   || t.Authors.Any(a => a.Name.Contains(filter))) 
                   .Skip((pageNumber - 1) * pageSize)
                   .Take(pageSize)
                   .OrderBy(sortmethod)
                   .ToListAsync();
            }
        }


        public async Task<Book> GetBook(int id)
        {
            return await _libraryDBContext.Books.Include(p => p.Authors).Include(p => p.Publisher)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
