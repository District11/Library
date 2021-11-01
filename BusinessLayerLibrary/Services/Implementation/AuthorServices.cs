using DataLayerLibrary;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementation
{
    public class AuthorServices : IAuthorServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public AuthorServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }

        public void AddAuthor()
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(int Id)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
