using BusinessLayerLibrary.DtoModel;
using BusinessLayerLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    public class LibraryBooksController : ControllerBase
    {
        private readonly IBookBusinessLayerServices _bookServices;

        public LibraryBooksController(IBookBusinessLayerServices bookServices)
        {

            _bookServices = bookServices;
        }

        [HttpGet("/api/books")]
        public ActionResult GetAllBooks(int pageSize, int pageNumber)
        {
            var books = _bookServices.GetAllBooks(pageSize, pageNumber);
            return Ok(books);
        }

        [HttpGet("/api/book/{id}")]
        public ActionResult GetBook(int id)
        {
           var book = _bookServices.GetBook(id);
            return Ok(book);
        }

        [HttpDelete("/api/book/{id}")]
        public ActionResult DeleteBook(int id)
        {
            _bookServices.DeleteBook(id);
            return Ok();
        }
        

        [HttpPost("/api/book")]
        public ActionResult CreateBook(BookRequest book)
        {
            _bookServices.CreateBook(book);
            return Ok();
        }

      /* [HttpGet("api/book/sorted/{sortedModelView}")]
        public ActionResult SortedLibrary(SortedModelDto sortedModelDto)
        {
            var library = _bookServices.Sorted(sortedModelDto);
            return Ok(library);
        }*/
    }
}
