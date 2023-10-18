using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.Author;

namespace BookStore.Service.Concrete
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _uow;
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;
        public AuthorService(IUnitOfWork uow, IAuthorRepository repository, IMapper mapper)
        {
            _uow = uow;
            _repository = repository;
            _mapper = mapper;
        }
        public Task<List<GetAuthorsDto>> GetAllAuthorsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<GetAuthorsDto> GetAuthorsByIdAsync(int id)
        {
            var author = await _repository.FindAuthorByIdAsync(id);
            if (author is null)
                throw new NotFoundException($"AuthorId: {id} not found.");
            var authorDto = _mapper.Map<GetAuthorsDto>(author);
            return authorDto;
        }

        public async Task<GetAuthorsDto> GetAuthorsByNameAsync(string name)
        {
            var author = await _repository.FindAuthorByNameAsync(name);
            if (author is null)
                throw new NotFoundException($"Author name: {name} not found.");
            var authorDto = _mapper.Map<GetAuthorsDto>(author);
            return authorDto;
        }
    }
}
