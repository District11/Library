using DataLayerLibrary;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementation
{
    public class PublisherServices : IPublisherServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public PublisherServices(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }

        public async void AddPublisher(Publisher publisher)
        {
            await _libraryDBContext.AddAsync(publisher);
            await _libraryDBContext.SaveChangesAsync();
        }

        public async void DeletePublisher(int Id)
        {
            var findPublisher = await _libraryDBContext.Publishers.FindAsync(Id);
            if(findPublisher != null)
            {
               _libraryDBContext.Remove(findPublisher);
               _libraryDBContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Невозможно удалить этого издателя!");
            }
        }

        public Publisher GetPublisher(int Id)
        {
            return _libraryDBContext.Publishers.Find(Id);
        }
    }
}
