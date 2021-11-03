using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using BusinessLayerLibrary.Services;
using DataLayerLibrary.Model;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services.Implementation
{
    public class BookServices : IBookServices
    {
        private readonly IBookBusinessLayerServices _bookBusinessLayerServices;

        private readonly IMapper _mapper;

        public BookServices(IBookBusinessLayerServices bookBusinessLayerServices, IMapper mapper)
        {
            _bookBusinessLayerServices = bookBusinessLayerServices;
            _mapper = mapper;
        }

        public async Task<bool> AddBook(BookView book)
        {
            var addBook = _mapper.Map<BookDto>(book);
            await _bookBusinessLayerServices.AddBook(addBook);
            return true;
        }

        public async Task<bool> DeleteBook(int id)
        {
            await _bookBusinessLayerServices.DeleteBook(id);
            return true;
        }

        public Task<IEnumerable<BookView>> GetAllBooks(int pageSizeint, int pageNumber)
        {
            throw new NotImplementedException();
        }

        /*  public Task<IEnumerable<BookView>> GetAllBooks(int pageSize, int pageNumber)
          {
              var library = _bookBusinessLayerServices.GetAllBooks(pageSize, pageNumber);
              //return _mapper.Map<BookView>(library/);

          }
        */
        public async Task<BookView> GetBook(int id)
        {
            var book = await _bookBusinessLayerServices.GetBook(id);
            return _mapper.Map<BookView>(book);
        }

        public Task Sorted(SortedModelView sortedModelView)
        {
            var library = _bookBusinessLayerServices.Sorted(_mapper.Map<SortedModelDto>(sortedModelView));
            return library;
        }
    }
}
