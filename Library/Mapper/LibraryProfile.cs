using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;
using System.Collections.Generic;

namespace Library.Mapper
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<BookResponse, Book>()
                .ForMember(dto => dto.Id, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2 => o2.Name))
                .ForMember(dto => dto.NumberOfPage, o1 => o1.MapFrom(o2 => o2.NumberOfPage))
                .ForMember(dto => dto.Publisher, o1 => o1.MapFrom(o2 => o2.Publisher))
                .ReverseMap();

            CreateMap<BookRequest, Book>()
                .ForMember(dto => dto.Id, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2 => o2.Name))
                .ForMember(dto => dto.NumberOfPage, o1 => o1.MapFrom(o2 => o2.NumberOfPage))
                .ForMember(dto => dto.Publisher, o1 => o1.MapFrom(o2 => o2.PublisherId))
                .ReverseMap();

            CreateMap<AuthorResponse, Author>()
                .ForMember(dto => dto.Id, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.LastName, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.MiddleName, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Activity, o1 => o1.MapFrom(o2 => o2.Id)).ReverseMap();

            CreateMap<AuthorRequest, Author>()
                .ForMember(dto => dto.Id, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.LastName, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.MiddleName, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Activity, o1 => o1.MapFrom(o2 => o2.Id)).ReverseMap();


            CreateMap<AuthorDto, Author>().ReverseMap();

            CreateMap<PublisherDto, Publisher>()
                .ForMember(dto => dto.Id, o1 => o1.MapFrom(o2 => o2.Id))
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2 => o2.Name))
                .ForMember(dto => dto.City, o1 => o1.MapFrom(o2 => o2.City))
                .ForMember(dto => dto.Books, o1 => o1.MapFrom(o2 => new List<Book> { { new Book { Id = o2.BooksId } } }))
                .ReverseMap();
        }
    }
}