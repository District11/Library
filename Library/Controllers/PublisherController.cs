using BusinessLayerLibrary.DtoModel;
using BusinessLayerLibrary.Services;
using DataLayerLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherBusinessLayerServices _services;

        public PublisherController(IPublisherBusinessLayerServices services)
        {
            _services = services;
        }

        [HttpGet("/api/publisher/{id}")]
        public ActionResult GetPublisher(int id)
        {
           var publisher = _services.GetPublisher(id);
            return Ok(publisher);
        }

        [HttpDelete("/api/publisher/{id}")]
        public ActionResult DeletePublisher(int id)
        {
             _services.DeletePublisher(id);
            return Ok();
        }

        [HttpPost("/api/publisher")]
        public ActionResult AddPublisher([FromBody]PublisherDto publisher)
        {
            _services.AddPublisher(publisher);
            return Ok();
        }
    }
}
