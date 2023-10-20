using BookStore.Core.Entities;

namespace BookStore.Core.Abstracts.Repositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Task<Genre> FindGenreByIdAsync(int id);
        Task<Genre> FindGenreByNameAsync(string name);
        // Genre with books
        Task<List<Genre>> GetAllGenreWithBooksAsync();
    }
}
