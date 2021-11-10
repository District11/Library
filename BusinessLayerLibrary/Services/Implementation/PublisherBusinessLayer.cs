using AutoMapper;
using DataLayerLibrary.Model;
using DataLayerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementation
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

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            var publisher = await _publisherDataLayerServices.GetAllPublishers();
            return publisher.Select(p => _mapper.Map<Publisher>(p));
        }

        public async Task<Publisher> GetPublisher(int id)
        {
            var listpublishers = await _publisherDataLayerServices.GetPublisher(id);
            return listpublishers;
        }
    }
}
