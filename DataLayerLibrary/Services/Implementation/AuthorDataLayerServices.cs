using DataLayerLibrary.Model;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _libraryDBContext.Authors.ToListAsync();
        }

        public async Task<Author> GetAuthor(int id)
        {
            var author = await _libraryDBContext.Authors.AsQueryable().Where(a => a.Id == id).FirstOrDefaultAsync();
            return author;
        }
    }
}
