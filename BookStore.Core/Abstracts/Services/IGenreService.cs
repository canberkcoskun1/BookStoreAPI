﻿using BookStoreAPI.DTO.Genre.Request;
using BookStoreAPI.DTO.Genre.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface IGenreService
    {
        Task<GetGenreDto> FindGenreByIdAsync(int id);
        Task<GetGenreDto> FindGenreByNameAsync(string name);
        Task<List<GetGenreDto>> GetAllGenreAsync();
        Task<List<GetGenreWithBooksDto>> GetAllGenreWithBooksAsync();
        Task AddGenreAsync(AddGenreDto addGenre);
        Task SoftDeleteGenreAsync(int id);
    }
}
