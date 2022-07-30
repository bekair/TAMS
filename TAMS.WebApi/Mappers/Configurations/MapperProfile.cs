using AutoMapper;
using TAMS.Common.DTOs.ResponseDTOs;
using TAMS.Entity.Concrete;

namespace TAMS.WebApi.Mappers.Configurations
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, RegisterUserDTO>();
            CreateMap<RegisterUserDTO, AppUser>();
        }
    }
}
