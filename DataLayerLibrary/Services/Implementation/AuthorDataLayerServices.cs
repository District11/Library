using DataLayerLibrary;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Implementation
{
    public class AuthorDataLayerServices : IAuthorDataLayerServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public AuthorDataLayerServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }

        public void AddAuthor(Author author)
        {
            _libraryDBContext.Add(author);
            _libraryDBContext.SaveChanges();
        }

        public void DeleteAuthor(int Id)
        {
            var findAuthor = _libraryDBContext.Authors.Find(Id);
            if(findAuthor != null)
            {
                _libraryDBContext.Remove(findAuthor);
                _libraryDBContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Невозможно удалить этого автора!");
            }
        }

        public Author GetAuthor(int Id)
        {
            return _libraryDBContext.Authors.Find(Id);
        }
    }
}
