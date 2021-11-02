using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary;
using DataLayerLibrary.Model;
using DataLayerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementation
{
    public class PublisherBusinessLayerServices : IPublisherBusinessLayerServices
    {
        private readonly IPublisherDataLayerServices _publisherDataLayerServices;
        private readonly IMapper _mapper;

        public PublisherBusinessLayerServices(IPublisherDataLayerServices publisherDataLayerServices, IMapper mapper)
        {
            _publisherDataLayerServices = publisherDataLayerServices;
            _mapper = mapper;
        }

        public void AddPublisher(PublisherDto publisherdto)
        {
            _publisherDataLayerServices.AddPublisher(new Publisher
            { 
            /// параметры для создвния нового пользователя
            ///
            });
        }

        public void DeletePublisher(int id)
        {
            _publisherDataLayerServices.GetPublisher(id);
            _publisherDataLayerServices.DeletePublisher(id);
        }

        public PublisherDto GetPublisher(int id)
        {
          var publisher = _publisherDataLayerServices.GetPublisher(id);
          return _mapper.Map<PublisherDto>(publisher);
        }
    }
}
