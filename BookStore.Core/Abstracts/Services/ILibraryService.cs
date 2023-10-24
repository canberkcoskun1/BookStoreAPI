using BookStoreAPI.DTO.Library.Request;
using BookStoreAPI.DTO.Library.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface ILibraryService
    {
        Task<GetLibraryDto> FindLibraryByIdAsync(int id);   
        Task AddLibraryByUserAsync(AddLibraryDto addLibrary);
        Task AddBooksToLibraryAsync(int bookId, int libraryId);
    }
}
