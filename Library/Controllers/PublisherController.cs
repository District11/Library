using AutoMapper;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary.Model;
using Library.DtoModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherBusinessLayer _publisherBusinessLayer;
        private readonly IMapper _mapper;
        public PublisherController(IMapper mapper, IPublisherBusinessLayer publisherBusinessLayer)
        {
            _mapper = mapper;
            _publisherBusinessLayer = publisherBusinessLayer;
        }


        [HttpGet("/api/publishers")]
        public async Task<ActionResult> GetAllPublishers(int pageSize, int pageNumber, string filter, string sorted)
        {
            var listpublishers = await _publisherBusinessLayer.GetAllPublishers(pageSize, pageNumber, filter, sorted);
            return Ok(listpublishers);
        }

        [HttpGet("/api/publisher/{id}")]
        public async Task<ActionResult> GetPublisher(int id)
        {
            var author = await _publisherBusinessLayer.GetPublisher(id);
            return Ok(author);
        }

        [HttpDelete("/api/publisher/{id}")]
        public async Task<ActionResult> DeletePublisher(int id)
        {
           await _publisherBusinessLayer.DeletePublisher(id);
           return Ok($"Пользователь с id: {id} удалён.");
        }


        [HttpPost("/api/publisher")]
        public async Task<ActionResult> CreatePublishers([FromBody]PublisherDto publisherdto)
        {
            var model = _mapper.Map<Publisher>(publisherdto);
            var publisher = await _publisherBusinessLayer.CreatePublisher(model);
            return Ok(publisher);
        }

    }
}
