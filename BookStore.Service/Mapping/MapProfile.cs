using AutoMapper;
using BookStore.Core.Entities;
using BookStoreAPI.DTO.User.Request;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, AddUserDto>().ReverseMap();
        }
    }
}
