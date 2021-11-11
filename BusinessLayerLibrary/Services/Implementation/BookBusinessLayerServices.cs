using AutoMapper;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary.Model;
using DataLayerLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services.Implementation
{
    public class BookBusinessLayerServices : IBookBusinessLayerServices
    {
        private readonly IBookDataLayerServices _bookDataLayerServices;

        private readonly IMapper _mapper;

        public BookBusinessLayerServices(IBookDataLayerServices bookDataLayerServices, IMapper mapper)
        {
            _bookDataLayerServices = bookDataLayerServices;
            _mapper = mapper;
        }

        public async Task<Book> CreateBook(Book book)
        {
            await _bookDataLayerServices.CreateBook(book);
            return book;
        }

        public async Task<bool> DeleteBook(int id)
        {
            try
            {
                var book = _bookDataLayerServices.GetBook(id);
                await _bookDataLayerServices.DeleteBook(id);
                return true;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return false;
            }
        }

        public async Task<IEnumerable<Book>> GetAllBooks(int pageSize, int pageNumber, string filter, string sorted)
        {
            if (pageSize == 0 || pageNumber == 0)
            {
                return null;
            }
            var books = await _bookDataLayerServices.GetAllBooks(pageSize, pageNumber, filter, sorted);
            return books.Select(e => _mapper.Map<Book>(e));
        }

        public async Task<Book> GetBook(int id)
        {
            var books = await _bookDataLayerServices.GetBook(id);
            return books;
        }
    }
}
