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
        public async Task<IActionResult> GetAllBooks(string filter, string sorted, int pageSize = 10, int pageNumber = 1)
        {
            var books = await _bookServices.GetAllBooks(pageSize, pageNumber, filter, sorted);
            return Ok(books);
        }

        [HttpGet("/api/book/{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
           var book = await _bookServices.GetBook(id);
            return Ok(book);
        }

        [HttpDelete("/api/book/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookServices.DeleteBook(id);
            return Ok();
        }
        

        [HttpPost("/api/book")]
        public async Task<IActionResult> CreateBook([FromBody]BookRequest book)
        {
           var model = _mapper.Map<Book>(book);
           var newBook = await _bookServices.CreateBook(model);
           return Ok(newBook);
        }
    }
}
