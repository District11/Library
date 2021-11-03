using BusinessLayerLibrary.DtoModel;
using BusinessLayerLibrary.Services;
using BusinessLayerLibrary.Services.Implementation;
using DataLayerLibrary.Model;
using Library.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public ActionResult AddBook(BookDto book)
        {
            _bookServices.AddBook(book);
            return Ok();
        }

        [HttpGet("api/book/sorted/{sortedModelView}")]
        public ActionResult SortedLibrary(SortedModelDto sortedModelDto)
        {
            var library = _bookServices.Sorted(sortedModelDto);
            return Ok(library);
        }
    }
}
