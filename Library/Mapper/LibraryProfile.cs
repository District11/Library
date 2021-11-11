using AutoMapper;
using DataLayerLibrary.Model;
using Library.DtoModel;
using System.Linq;

namespace Library.Mapper
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {

            CreateMap<BookRequest, Book>()
               .ForMember(dto => dto.Authors, o1 => o1.MapFrom(o2 => o2.AuthorId.Select(o3 => new Author { Id = o3 })))
               .ForMember(dto => dto.Publisher, o1 => o1.MapFrom((o2 => new Publisher { Id = o2.PublisherId })))
               .ReverseMap();

            CreateMap<BookDto, Book>()
               .ReverseMap();

            CreateMap<AuthorRequest, Author>().ReverseMap();

            CreateMap<AuthorDto, Author>()
                .ReverseMap();

            CreateMap<PublisherDto, Publisher>()
                .ReverseMap();
        }
    }
}