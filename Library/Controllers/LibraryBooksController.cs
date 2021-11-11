using AutoMapper;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary.Models;
using Library.DtoModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    public class LibraryBooksController : ControllerBase
    {
        private readonly IBookBusinessLayerServices _bookServices;
        private readonly IMapper _mapper;

        public LibraryBooksController(IBookBusinessLayerServices bookServices, IMapper mapper)
        {
            _bookServices = bookServices;
            _mapper = mapper;
        }

        [HttpGet("/api/books")]
        public async Task<ActionResult> GetAllBooks(int pageSize, int pageNumber, string filter, string sorted)
        {
            var books = await _bookServices.GetAllBooks(pageSize, pageNumber, filter, sorted);
            return Ok(books);
        }

        [HttpGet("/api/book/{id}")]
        public async Task<ActionResult> GetBook(int id)
        {
           var book = await _bookServices.GetBook(id);
            return Ok(book);
        }

        [HttpDelete("/api/book/{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _bookServices.DeleteBook(id);
            return Ok();
        }
        

        [HttpPost("/api/book")]
        public async Task<ActionResult> CreateBook([FromBody]BookRequest book)
        {
           var model = _mapper.Map<Book>(book);
           var newBook = await _bookServices.CreateBook(model);
           return Ok(newBook);
        }
    }
}
