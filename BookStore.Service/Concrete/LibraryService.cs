using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.Library.Request;
using BookStoreAPI.DTO.Library.Response;

namespace BookStore.Service.Concrete
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public LibraryService(ILibraryRepository libraryRepository, IUnitOfWork uow, IMapper mapper)
        {
            _libraryRepository = libraryRepository;
            _uow = uow;
            _mapper = mapper;
        }

        public async Task AddLibraryByUserAsync(AddLibraryDto addLibrary)
        {
            var library = _mapper.Map<Library>(addLibrary);
            await _libraryRepository.AddAsync(library);
            await _uow.CommitAsync();
        }

        public async Task<GetLibraryDto> FindLibraryByIdAsync(int id)
        {
            var library = await _libraryRepository.FindLibaryByIdAsync(id);
            if (library is null)
                throw new NotFoundException($"LibraryId: {id} not found");
            var libraryDto = _mapper.Map<GetLibraryDto>(library);
            libraryDto.Books = _mapper.Map<List<GetBooksDto>>(libraryDto.Books); 
            return libraryDto;
        }

    }
}
