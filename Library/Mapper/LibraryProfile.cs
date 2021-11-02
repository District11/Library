using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Mapper
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<Book, BookDto>();

            CreateMap<BookDto, Book>();

            CreateMap<Author, AuthorDto>();

            CreateMap<AuthorDto, Author>();

            CreateMap<Publisher, PublisherDto>();

            CreateMap<PublisherDto, Publisher>();

        }
    }
}
