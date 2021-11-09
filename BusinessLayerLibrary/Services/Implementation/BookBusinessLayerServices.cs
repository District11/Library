using AutoMapper;
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

        public async Task<bool> CreateBook(Book book)
        {
            try
            {

                await _bookDataLayerServices.CreateBook(new Book
                {
                    Id = book.Id,
                    Name = book.Name, 
                    NumberOfPage = book.NumberOfPage,
                    PublisherId = book.PublisherId,
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

        public async Task<IEnumerable<Book>> GetAllBooks(int pageSize, int pageNumber)
        {
            var books = await _bookDataLayerServices.GetAllBooks(pageSize, pageNumber);
            return books.Select(e => _mapper.Map<Book>(e));
        }

        public async Task<Book> GetBook(int id)
        {
            var books = await _bookDataLayerServices.GetBook(id);
            return books;
        }

      /*  public Task Sorted(SortedModelDto sortedModelDto)
        {
            var librarySorted = _bookDataLayerServices.Sorted(_mapper.Map<SortedModel>(sortedModelDto));
            return librarySorted;
        }*/
    }
}
