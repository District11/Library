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
            CreateMap<BookView, BookDto>();

            CreateMap<BookDto, BookView>();

            CreateMap<AuthorView, AuthorDto>();

            CreateMap<AuthorDto, AuthorView>();

            CreateMap<PublisherView, PublisherDto>();

            CreateMap<PublisherDto, PublisherView>();

            CreateMap<SortedModelView, SortedModelDto>();

            CreateMap<SortedModelDto, SortedModelView>();

            CreateMap<PagingView, PagingDto>();

            CreateMap<PagingDto, PagingView>();
        }
    }
}
