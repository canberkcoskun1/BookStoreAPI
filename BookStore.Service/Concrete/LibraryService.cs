using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.Library.Request;
using BookStoreAPI.DTO.Library.Response;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service.Concrete
{
    public class LibraryService : ILibraryService
    {
        private readonly IBookRepository _bookRepository;   
        private readonly ILibraryRepository _libraryRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public LibraryService(ILibraryRepository libraryRepository, IUnitOfWork uow, IMapper mapper, IBookRepository bookRepository)
        {
            _libraryRepository = libraryRepository;
            _uow = uow;
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task AddBooksToLibraryAsync(int bookId, int libraryId)
        {
            var library = await _libraryRepository.FindLibaryByIdAsync(libraryId);
            var books = await _bookRepository.FindBookByIdAsync(bookId);
            if (library is null || books is null)
                throw new NotFoundException($"BookId: {bookId} or LibraryId: {libraryId} not found.");
            library.Books.Add(books);
            await _uow.CommitAsync();
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
            return libraryDto;
        }


    }
}
