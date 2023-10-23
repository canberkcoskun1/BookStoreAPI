using BookStoreAPI.DTO.Library.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface ILibraryService
    {
        Task<GetLibraryDto> FindLibraryByIdAsync(int id);   
    }
}
