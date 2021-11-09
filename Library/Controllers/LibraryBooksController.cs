using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using BusinessLayerLibrary.Services;
using DataLayerLibrary.Model;
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
        public async Task<ActionResult> GetAllBooks(int pageSize, int pageNumber)
        {
            var books = await _bookServices.GetAllBooks(pageSize, pageNumber);
            return Ok(books);
        }

        [HttpGet("/api/book/{id}")]
        public async Task<ActionResult> GetBook(int id)
        {
           var book = _bookServices.GetBook(id);
            return Ok(book);
        }

        [HttpDelete("/api/book/{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _bookServices.DeleteBook(id);
            return Ok();
        }
        

        [HttpPost("/api/book")]
        public async Task<ActionResult> CreateBook(BookRequest book)
        {
           await _bookServices.CreateBook(book);
           return Ok();
        }
    }
}
