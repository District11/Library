using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;

namespace BusinessLayerLibrary.Mapper
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
