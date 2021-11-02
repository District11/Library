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
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorBusinessLayerServices _authorServices;

        public AuthorController (IAuthorBusinessLayerServices authorServices)
        {
            _authorServices = authorServices;
        }

        [HttpGet("/api/author/{id}")]
        public ActionResult GetAuthor(int id)
        {
            var author = _authorServices.GetAuthor(id);
            return Ok(author);
        }

        [HttpDelete("/api/author/{id}")]
        public ActionResult DeleteAuthor(int id)
        {
            _authorServices.DeleteAuthor(id);
            return Ok();
        }

        [HttpPost("/api/author")]
        public ActionResult AddAuthor(AuthorDto author)
        {
            _authorServices.AddAuthor(author);
            return Ok();
        } 
    }
}
