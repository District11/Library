using AutoMapper;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary.Models;
using DataLayerLibrary.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementations
{
    public class PublisherBusinessLayer : IPublisherBusinessLayer
    {
        private readonly IPublisherDataLayerServices _publisherDataLayerServices;
        private readonly IMapper _mapper;

        public PublisherBusinessLayer(IPublisherDataLayerServices publisherDataLayerServices, IMapper mapper)
        {
            _publisherDataLayerServices = publisherDataLayerServices;
            _mapper = mapper;
        }



        public async Task<Publisher> CreatePublisher(Publisher publisher)
        {
            await _publisherDataLayerServices.CreatePublisher(publisher);
            return publisher;  
        }

        public async Task<bool> DeletePublisher(int id)
        {
            try
            {
                await _publisherDataLayerServices.DeletePublisher(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishers(int pageSize, int pageNumber, string filter, string sorted)
        {
            if(pageSize<1 || pageNumber < 1)
            {
                return null;
            }
            var publisher = await _publisherDataLayerServices.GetAllPublishersModifie(pageSize, pageNumber, filter, sorted);
            return publisher.Select(p => _mapper.Map<Publisher>(p));
        }

        public async Task<Publisher> GetPublisher(int id)
        {
            var listpublishers = await _publisherDataLayerServices.GetPublisher(id);
            return listpublishers;
        }
    }
}
