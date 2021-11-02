using DataLayerLibrary;
using DataLayerLibrary.Model;
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
        public void AddBook(Book book)
        {
            _libraryDBContext.Add(book);
            _libraryDBContext.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
            var findBook = _libraryDBContext.Books.Find(Id);
            if(findBook != null)
            {
                _libraryDBContext.Remove(findBook);
                _libraryDBContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Невозможно удалить эту книгу!");
            }
        }

        public Book GetBook(int Id)
        {
           return _libraryDBContext.Books.Find(Id);
        }
    }
}
