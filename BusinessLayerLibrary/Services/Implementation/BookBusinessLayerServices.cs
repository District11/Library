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
        public void AddBook(BookDto book)
        {
            bookBusinessLayerServices.AddBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookDataLayerServices.DeleteBook(id);
        }

        public BookDto GetBook(int id)
        {
            return _bookDataLayerServices.GetBook(id);
        }
    }
}
