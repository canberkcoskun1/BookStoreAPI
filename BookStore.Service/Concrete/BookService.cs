using AutoMapper;
using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStore.Core.UnitOfWorks;
using BookStore.Service.Exceptions;
using BookStoreAPI.DTO.Book.Request;
using BookStoreAPI.DTO.Book.Response;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Service.Concrete
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        public BookService(IBookRepository bookRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _uow = unitOfWork;
        }
        public async Task AddBookAsync(AddBooksDto addBooks)
        {
            var books = _mapper.Map<Book>(addBooks);
            await _bookRepository.AddAsync(books);
            await _uow.CommitAsync();
        }

        public async Task<List<GetBooksDto>> GetAllBooksAsync()
        {
            var books = await _bookRepository.GetAll().ToListAsync();
            var bookDto = _mapper.Map<List<GetBooksDto>>(books);
            return bookDto;
        }

        public async Task<GetBooksDto> GetBookByIdAsync(int id)
        {
            var books = await _bookRepository.FindBookByIdAsync(id);
            if (books == null)
                throw new NotFoundException($"BookId: {id} not found.");
            var bookDto = _mapper.Map<GetBooksDto>(books);
            return bookDto;
        }

        public async Task<GetBooksDto> GetBookByNameAsync(string bookname)
        {
            var books = await _bookRepository.FindBookByNameAsync(bookname);
            if (books == null)
                throw new NotFoundException($"Bookname: {bookname} not found.");
            var bookDto = _mapper.Map<GetBooksDto>(books);
            return bookDto;
        }

        public async Task RemoveBookAsync(int id)
        {
            var books = await _bookRepository.GetByIdAsync(id);
            if (books == null)
                throw new NotFoundException($"BookId: {id} not found.");
            _bookRepository.Remove(books);
            await _uow.CommitAsync();
        }
    }
}
