using DataLayerLibrary.Models;
using DataLayerLibrary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Implementations
{
    public class AuthorDataLayerServices : IAuthorDataLayerServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public AuthorDataLayerServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }

        public async Task CreateAuthor(Author author)
        {
           await _libraryDBContext.AddAsync(author);
           await _libraryDBContext.SaveChangesAsync(); 
        }

        public async Task DeleteAuthor(int id)
        {
            var author =  await _libraryDBContext.Authors.FindAsync(id);

            if(author != null)
            {
                _libraryDBContext.Authors.Remove(author);
                await _libraryDBContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Нет такого пользователя.");
            }
        }

        public async Task<IEnumerable<Author>> GetAllAuthors(int pageSize, int pageNumber, string filter, string sort)
        {
            var sortmethod = Author.GetSortExpressions(sort);

            var queery = _libraryDBContext.Authors.AsQueryable();

            if (filter != null)
            {
                queery = _libraryDBContext.Authors.Where(t => t.LastName.Contains(filter) || t.MiddleName.Contains(filter) || t.Name.Contains(filter));
            }

            return queery.OrderBy(sortmethod).Skip((pageNumber - 1) * pageSize).Take(pageSize); 
        }

        public async Task<Author> GetAuthor(int id)
        {
            var author = await _libraryDBContext.Authors.AsQueryable().Where(a => a.Id == id).FirstOrDefaultAsync();
            return author;
        }
    }
}
