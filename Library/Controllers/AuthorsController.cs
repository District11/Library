using AutoMapper;
using BusinessLayerLibrary.Services;
using DataLayerLibrary.Model;
using Library.DtoModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorBussinessLayer _authorBussinessLayer;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorBussinessLayer authorBussinessLayer, IMapper mapper)
        {
            _authorBussinessLayer = authorBussinessLayer;
            _mapper = mapper;
        }


        [HttpGet("/api/authors")]
        public async Task<ActionResult> GetAllAuthors()
        {
            var listAuthors = await _authorBussinessLayer.GetAllAuthors();
            return Ok(listAuthors);
        }


        [HttpGet("/api/author/{id}")]
        public async Task<ActionResult> GetAuthor(int id)
        {
            var authors = await _authorBussinessLayer.GetAuthor(id);
            return Ok(authors);
        }

        [HttpDelete("/api/author/{id}")]
        public async Task<ActionResult> DeleteAuthor(int id)
        {
            var deletedAuthor = await _authorBussinessLayer.DeleteAuthor(id);
            return Ok(deletedAuthor);
        }

        [HttpPost("/api/author")]
        public async Task<bool> CreateAuthor([FromBody] AuthorRequest authorRequest)
        {
            var model = _mapper.Map<Author>(authorRequest);
            var author = await _authorBussinessLayer.CreateAuthor(model);
            return author;
        }

    }
}
