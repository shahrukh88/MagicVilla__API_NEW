using AutoMapper;
using Magic_VillaAPI.Models.Dto;
using Magic_VillaAPI.Models;


namespace Magic_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {

            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();


            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
            CreateMap<ApplicationUser,UserDTO>().ReverseMap();

        }
    }
}