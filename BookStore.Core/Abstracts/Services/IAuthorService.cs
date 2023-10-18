using BookStoreAPI.DTO.Author;

namespace BookStore.Core.Abstracts.Services
{
    public interface IAuthorService
    {
        Task<GetAuthorsDto> GetAuthorsByIdAsync(int id);
        Task<GetAuthorsDto> GetAuthorsByNameAsync(string name);
        Task<List<GetAuthorsDto>> GetAllAuthorsAsync();
    }
}
