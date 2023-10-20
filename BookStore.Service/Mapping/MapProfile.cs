using AutoMapper;
using BookStore.Core.Entities;
using BookStoreAPI.DTO.Author.Request;
using BookStoreAPI.DTO.Author.Response;
using BookStoreAPI.DTO.Book.Request;
using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.Genre.Response;
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
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<Book, GetBooksDto>().ReverseMap();
            CreateMap<Book, AddBooksDto>().ReverseMap();
            CreateMap<Author, GetAuthorsDto>().ReverseMap();
            CreateMap<Author, AddAuthorDto>().ReverseMap();
            CreateMap<Genre, GetGenreDto>().ReverseMap();
        }
    }
}
