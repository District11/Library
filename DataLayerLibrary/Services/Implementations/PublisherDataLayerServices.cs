using DataLayerLibrary.Models;
using DataLayerLibrary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayerLibrary.Services.Implementations
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
            if (publisher != null)
            {
                _libraryDBContext.Publishers.Remove(publisher);
                await _libraryDBContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Нет такого издателя.");
            }
        }

        public Task<IEnumerable<Publisher>> GetAllPublishersModifie(int pageSize, int pageNumber, string filter, string sort)
        {
            var sortmethod = Publisher.GetSortExpressions(sort);

            var queery = _libraryDBContext.Publishers
                .OrderBy(sortmethod)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

            if (filter != null)
            {
                queery = _libraryDBContext.Publishers
                    .Where(t => t.Name.Contains(filter) || t.City.Contains(filter))
                    .OrderBy(sortmethod)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize);
            }

            return Task.FromResult(queery.AsEnumerable());
        }

        public Task<Publisher> GetPublisher(int id)
        {
            return _libraryDBContext.Publishers.AsQueryable().Where(p => p.Id == id).FirstOrDefaultAsync();
        }
    }
}
