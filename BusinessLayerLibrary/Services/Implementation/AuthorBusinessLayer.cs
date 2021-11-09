using AutoMapper;

using DataLayerLibrary.Model;
using DataLayerLibrary.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public async Task<bool> CreateAuthor(Author author)
        {
            try
            {

                await _authorDataLayerServices.CreateAuthor(new Author
                {
                    Id = author.Id,
                    LastName = author.LastName,
                    MiddleName = author.MiddleName,
                    Name = author.Name,
                    Activity = author.Activity

                });
                return true;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return false;
            }
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

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            var authors = await _authorDataLayerServices.GetAllAuthors();
            return authors.Select(e => _mapper.Map<Author>(e));
        }

        public async Task<Author> GetAuthor(int id)
        {
            
            var author = await _authorDataLayerServices.GetAuthor(id);
            return author;
        }
    }
}
