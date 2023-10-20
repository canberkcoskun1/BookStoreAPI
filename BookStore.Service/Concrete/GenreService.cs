using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO.Genre.Response;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service.Concrete
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }
        public async Task<GetGenreDto> FindGenreByIdAsync(int id)
        {
            var genre = await _genreRepository.FindGenreByIdAsync(id);
            var genreDto = _mapper.Map<GetGenreDto>(genre);
            return genreDto;
        }

        public async Task<GetGenreDto> FindGenreByNameAsync(string name)
        {
            var genreByName = await _genreRepository.FindGenreByNameAsync(name);
            var genreDto = _mapper.Map<GetGenreDto>(genreByName);
            return genreDto;
        }

        public async Task<List<GetGenreDto>> GetAllGenreAsync()
        {
            var genres = await _genreRepository.GetAll().ToListAsync();
            var genresDto = _mapper.Map<List<GetGenreDto>>(genres);
            return genresDto;
        }

        public async Task<List<GetGenreWithBooksDto>> GetAllGenreWithBooksAsync()
        {
            var genres = await _genreRepository.GetAllGenreWithBooksAsync();
            var genresDto = _mapper.Map<List<GetGenreWithBooksDto>>(genres);
            return genresDto;
        }

        
    }
}
