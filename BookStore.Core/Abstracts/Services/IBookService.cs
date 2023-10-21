using BookStoreAPI.DTO.Book.Request;
using BookStoreAPI.DTO.Book.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface IBookService 
    {
        Task AddBookAsync(AddBooksDto addBooks);
        Task<List<GetBooksDto>> GetAllBooksAsync();
        Task<GetBooksDto> GetBookByIdAsync(int id);
        Task<GetBooksDto> GetBookByNameAsync(string bookname);

        //Task <BookWithAuthorDto> GetBookByAuthorAsync();
        Task RemoveBookAsync(int id);
        Task<GetBooksDto> UpdateBookAsync(int id, UpdateBooksDto updateBooks);
    }
}
