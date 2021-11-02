using DataLayerLibrary;
using DataLayerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerLibrary.Services;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace DataLayerLibrary.Services.Implementation
{
    public class PublisherDataLayerServices : IPublisherDataLayerServices
    {
        private readonly LibraryDBContext _libraryDBContext;

        public PublisherDataLayerServices(LibraryDBContext libraryDBContext)
        {
            this._libraryDBContext = libraryDBContext;
        }

        public void AddPublisher(Publisher publisher)
        {
           _libraryDBContext.Add(publisher);
            _libraryDBContext.SaveChanges();
        }

        public void DeletePublisher(int id)
        {
            _libraryDBContext.Entry(id).State = EntityState.Deleted;
            _libraryDBContext.SaveChanges();
        }

        public Publisher GetPublisher(int id)
        {
            return _libraryDBContext.Publishers.AsQueryable().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
