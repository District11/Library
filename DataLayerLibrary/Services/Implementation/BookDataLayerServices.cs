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
        public async Task CreateBook(Book book)
        {
            _libraryDBContext.Entry(book.ListAuthor.ToList()).State = EntityState.Unchanged;
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

        public async Task<IEnumerable<Book>> GetAllBooks(int pageSize, int pageNumber)
        {
            return await _libraryDBContext.Books.Skip(pageSize*(pageNumber - 1)).Take(pageSize).ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            return await _libraryDBContext.Books.AsQueryable().Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        /*public Task Sorted(SortedModel sortedModel)
        {

            IQueryable<Book> books = _libraryDBContext.Books;
            books = sortedModel switch
            {
                SortedModel.NameBookSorted => books.OrderBy(b => b.Name),
                SortedModel.CountPagesSorted => books.OrderBy(b => b.NumberOfPage),
                SortedModel.LastNameSorted => books.OrderBy(b => b.ListAuthor),
                SortedModel.CityPublisherSorted => books.OrderBy(b => b.Publisher.City)
            };
            return books.AsNoTracking().ToListAsync();
        }*/
    }
}
