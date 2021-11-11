using DataLayerLibrary.Model;
using DataLayerLibrary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Publisher>> GetAllPublishersModifie(int pageSize, int pageNumber, string filter, string sorted)
        {
            var sortmethod = Publisher.GetSortExpressions(sorted);
            if (filter == null)
            {
                return await _libraryDBContext.Publishers
               .Skip((pageNumber - 1) * pageSize)
               .Take(pageSize)
               .OrderBy(sortmethod)
               .ToListAsync();
            }
            else
            {
                return await _libraryDBContext.Publishers
                   .Where(t => t.Name.Contains(filter) || t.City.Contains(filter))
                   .Skip((pageNumber - 1) * pageSize)
                   .Take(pageSize)
                   .OrderBy(sortmethod)
                   .ToListAsync();
            }
        }

        public Task<Publisher> GetPublisher(int id)
        {
            return _libraryDBContext.Publishers.AsQueryable().Where(p => p.Id == id).FirstOrDefaultAsync();
        }
    }
}
