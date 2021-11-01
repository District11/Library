using DataLayerLibrary;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementation
{
    public class BookServices : IBookServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public BookServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }
        public void AddBook(Book book)
        {
            
        }

        public void DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
