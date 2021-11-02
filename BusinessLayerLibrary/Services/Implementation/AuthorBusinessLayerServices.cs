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
    public class AuthorBusinessLayerServices : IAuthorBusinessLayerServices
    {
        private readonly IAuthorDataLayerServices _authorDataLayerServices;

        private readonly IMapper _mapper;

        public AuthorBusinessLayerServices(IAuthorDataLayerServices authorDataLayerServices, IMapper mapper)
        {
            _authorDataLayerServices = authorDataLayerServices;
            _mapper = mapper;
        }

        public void AddAuthor(AuthorDto author)
        {
            _authorDataLayerServices.AddAuthor(author);
        }

        public void DeleteAuthor(int id)
        {
            authorDataLayerServices.DeleteAuthor(id);
        }

        public Author GetAuthor(int id)
        {
            return authorDataLayerServices.GetAuthor(id);
        }
    }
}
