using AutoMapper;
using TAMS.Common.DTOs.ResponseDTOs;
using TAMS.Entity.Concrete;

namespace TAMS.WebApi.Mappers.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, UserDTO>();
            CreateMap<UserDTO, AppUser>();
        }
    }
}
