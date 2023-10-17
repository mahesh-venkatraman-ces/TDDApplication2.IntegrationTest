using AutoMapper;
using TDDApplication2.DataAccessLayer.Entities;
using TDDApplication2.DTO.DTOs;

namespace TDDApplication2.DataAccessLayer.AutomapperProfiles
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<User, UserDTO>().ReverseMap();
            }
        }
    }
}
