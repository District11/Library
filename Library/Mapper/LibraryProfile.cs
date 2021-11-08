using AutoMapper;
using BusinessLayerLibrary.DtoModel;
using DataLayerLibrary.Model;

namespace Library.Mapper
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<GetBookDto, Book>()
                .ForMember(dto => dto.Id, o1 => o1.MapFrom(o2=> o2.Id))
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2=> o2.Name))
                .ForMember(dto => dto.NumberOfPage, o1 => o1.MapFrom(o2=> o2.NumberOfPage))
                .ForMember(dto => dto.Publisher, o1 => o1.MapFrom(o2=> o2.Publisher))
                .ReverseMap();

            CreateMap<CreateBookDto, GetBookDto>()
                .ForMember(dto => dto.Name, o1 => o1.MapFrom(o2 => o2.Name))
                .ForMember(dto => dto.NumberOfPage, o1 => o1.MapFrom(o2 => o2.NumberOfPage))
                .ForMember(dto => dto.Publisher, o1 => o1.MapFrom(o2 => o2.PublisherId)).ReverseMap();
        }
    }
}
