using AutoMapper;
using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO.Genre.Response;

namespace BookStore.Service.Concrete
{
    public class GenreService : IGenreService
    {
        private readonly IGenreService _genreService;
        private readonly IMapper _mapper;
        public GenreService(IGenreService genreService, IMapper mapper)
        {
            _genreService = genreService;
        }
        public async Task<GetGenreDto> FindGenreByIdAsync(int id)
        {
            var genre = await _genreService.FindGenreByIdAsync(id);
            var genreDto = _mapper.Map<GetGenreDto>(genre);
            return genreDto;
        }

        public async Task<GetGenreDto> FindGenreByNameAsync(string name)
        {
            var genreByName = await _genreService.FindGenreByNameAsync(name);
            var genreDto = _mapper.Map<GetGenreDto>(genreByName);
            return genreDto;
        }

        public async Task<List<GetGenreDto>> GetAllGenreAsync()
        {
            var genres = await _genreService.GetAllGenreAsync();
            var genresDto = _mapper.Map<List<GetGenreDto>>(genres);
            return genresDto;
        }
    }
}
