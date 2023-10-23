using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.Genre.Request;
using BookStoreAPI.DTO.Genre.Response;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service.Concrete
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        public GenreService(IGenreRepository genreRepository, IMapper mapper, IUnitOfWork uow)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
            _uow = uow;
        }
        public async Task<GetGenreDto> FindGenreByIdAsync(int id)
        {
            var genre = await _genreRepository.FindGenreByIdAsync(id);
            if (genre == null)
                throw new NotFoundException($"Genre Name: {id} not found.");
            var genreDto = _mapper.Map<GetGenreDto>(genre);
            return genreDto;
        }

        public async Task<GetGenreDto> FindGenreByNameAsync(string name)
        {
            var genreByName = await _genreRepository.FindGenreByNameAsync(name);
            if (genreByName == null)
                throw new NotFoundException($"Genre Name: {genreByName} not found.");
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
        public async Task AddGenreAsync(AddGenreDto addGenre)
        {
            var genre = _mapper.Map<Genre>(addGenre);
            await _genreRepository.AddAsync(genre);
            await _uow.CommitAsync();

        }
        public async Task SoftDeleteGenreAsync(int id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);
            if (genre == null)
                throw new NotFoundException($"GenreId: {id} not found.");
            _genreRepository.Remove(genre);
            await _uow.CommitAsync();
        }
        
        

        
    }
}
