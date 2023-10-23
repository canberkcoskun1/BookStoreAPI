using AutoMapper;
using BookStore.Core.Entities;
using BookStoreAPI.DTO.Author.Request;
using BookStoreAPI.DTO.Author.Response;
using BookStoreAPI.DTO.Book.Request;
using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.Genre.Request;
using BookStoreAPI.DTO.Genre.Response;
using BookStoreAPI.DTO.Library.Request;
using BookStoreAPI.DTO.Library.Response;
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
            CreateMap<User, GetUserForLibraryDto>().ReverseMap();

            CreateMap<Book, GetBooksDto>().ReverseMap();
            CreateMap<Book, AddBooksDto>().ReverseMap();
            CreateMap<Book, UpdateBooksDto>().ReverseMap();
            CreateMap<Book, GetBooksWithAuthorsDto>().ReverseMap();

            CreateMap<Author, GetAuthorsDto>().ReverseMap();
            CreateMap<Author, AddAuthorDto>().ReverseMap();
            CreateMap<Author, GetAuthorsBookCountDto>().ReverseMap();
            CreateMap<Author, GetAuthorDetailDto>().ReverseMap();

            CreateMap<Genre, GetGenreDto>().ReverseMap();
            CreateMap<Genre, GetGenreWithBooksDto>().ReverseMap();
            CreateMap<Genre, AddGenreDto>().ReverseMap();

            CreateMap<Library, GetLibraryDto>().ReverseMap();
            CreateMap<Library, AddLibraryDto>().ReverseMap();
        }
    }
}
