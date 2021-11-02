using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary;
using DataLayerLibrary.Model;
using DataLayerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<bool> AddBook(BookDto book)
        {
            try
            {
                await _bookDataLayerServices.AddBook(new Book
                {
                    Id = book.Id,
                    //Author = book.AuthorDto.Id,
                    Name = book.Name,
                    Count = book.Count,
                    //Publisher = book.Publisher
                });
                return true;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return false;
            }
            
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

        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
            var books = await _bookDataLayerServices.GetAllBooks();
            return books.Select(e => _mapper.Map<BookDto>(e));
        }

        public async Task<Book> GetBook(int id)
        {
            var books = await _bookDataLayerServices.GetBook(id);
            return books;
        }
    }
}
