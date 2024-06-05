using AutoMapper;
using dosyaApi.Dtos;
using dosyaApi.Models;

namespace dosyaApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            

     
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<Fillies,FilliesDto>().ReverseMap();   
            CreateMap<Folder, FolderDto>().ReverseMap();
            CreateMap<Folder, Folderfilles>()
                .ForMember(opt=>opt.Fillies, opt=>opt.MapFrom(path=>path.Files))
                .ReverseMap();


            CreateMap<Category, CategoryDto>().ReverseMap();

        }
    }
}


