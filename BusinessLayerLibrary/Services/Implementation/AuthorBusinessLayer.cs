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
    public class AuthorBusinessLayer : IAuthorBussinessLayer
    {
        private readonly IAuthorDataLayerServices _authorDataLayerServices;

        private readonly IMapper _mapper;

        public AuthorBusinessLayer(IAuthorDataLayerServices authorDataLayerServices, IMapper mapper)
        {
            _authorDataLayerServices = authorDataLayerServices;
            _mapper = mapper;
        }


        public async Task<Author> CreateAuthor(Author author)
        {
            await _authorDataLayerServices.CreateAuthor(author);
            return author;
        }

        public async Task<bool> DeleteAuthor(int id)
        {
            try
            {
                var book = _authorDataLayerServices.GetAuthor(id);
                await _authorDataLayerServices.DeleteAuthor(id);
                return true;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return false;
            }
        }

        public async Task<IEnumerable<Author>> GetAllAuthors(int pageSize, int pageNumber, string filter, string sorted)
        {
            if(pageSize == 0 || pageNumber == 0)
            {
                return null;
            }
            var authors = await _authorDataLayerServices.GetAllAuthors(pageSize, pageNumber, filter, sorted);
            return authors.Select(e => _mapper.Map<Author>(e));
        }

        public async Task<Author> GetAuthor(int id)
        {

            var author = await _authorDataLayerServices.GetAuthor(id);
            return author;
        }
    }
}
