using BookStoreAPI.DTO.Author.Request;
using BookStoreAPI.DTO.Author.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface IAuthorService
    {
        Task<GetAuthorsDto> GetAuthorsByIdAsync(int id);
        Task<GetAuthorsDto> GetAuthorsByNameAsync(string name);
        Task<List<GetAuthorsDto>> GetAllAuthorsAsync();
        Task RemoveAuthorAsync(int id);
        Task AddAuthorAsync(AddAuthorDto addAuthor);
        Task<GetAuthorsBookCountDto> GetAuthorsBookCountAsync(int id);

    }
}
