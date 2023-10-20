using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.Author.Request;
using BookStoreAPI.DTO.Author.Response;

namespace BookStore.Service.Concrete
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _uow;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(IUnitOfWork uow, IAuthorRepository repository, IMapper mapper)
        {
            _uow = uow;
            _authorRepository = repository;
            _mapper = mapper;

        }

        public async Task AddAuthorAsync(AddAuthorDto addAuthor)
        {
            var user = _mapper.Map<Author>(addAuthor);
            await _authorRepository.AddAsync(user);
            await _uow.CommitAsync();
        }

        public async Task<List<GetAuthorsDto>> GetAllAuthorsAsync()
        {
            var authors = await _authorRepository.GetAllAuthorsWithBooksAsync();
            var authorDto = _mapper.Map<List<GetAuthorsDto>>(authors);
            return authorDto;
        }

        public async Task<GetAuthorsDto> GetAuthorsByIdAsync(int id)
        {
            var author = await _authorRepository.FindAuthorByIdAsync(id);
            if (author is null)
                throw new NotFoundException($"AuthorId: {id} not found.");

            var authorDto = _mapper.Map<GetAuthorsDto>(author);

            return authorDto;
        }

        public async Task<GetAuthorsDto> GetAuthorsByNameAsync(string name)
        {
            var author = await _authorRepository.FindAuthorByNameAsync(name);
            if (author is null)
                throw new NotFoundException($"Author name: {name} not found.");
            var authorDto = _mapper.Map<GetAuthorsDto>(author);
            return authorDto;
        }
        public async Task RemoveAuthorAsync(int id)
        {
            var author = await _authorRepository.FindAuthorByIdAsync(id);
            if (author is null)
                throw new NotFoundException($"AuthorId: {id} not found");
            _authorRepository.Remove(author);
            await _uow.CommitAsync();
        }

    }
}
