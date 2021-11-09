using DataLayerLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Implementation
{
    public class PublisherDataLayerServices : IPublisherDataLayerServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public PublisherDataLayerServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }

        public async Task CreatePublisher(Publisher publisher)
        {
            _libraryDBContext.Entry(publisher.Books.ToList()).State = EntityState.Unchanged;
            await _libraryDBContext.Publishers.AddAsync(publisher);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task DeletePublisher(int id)
        {
            var publisher = await _libraryDBContext.Publishers.FindAsync(id);
            if(publisher != null)
            {
                _libraryDBContext.Publishers.Remove(publisher);
               await _libraryDBContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Нет такого издателя.");
            }
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _libraryDBContext.Publishers.ToListAsync();
        }

        public Task<Publisher> GetPublisher(int id)
        {
            return _libraryDBContext.Publishers.AsQueryable().Where(p => p.Id == id).FirstOrDefaultAsync();
        }
    }
}
