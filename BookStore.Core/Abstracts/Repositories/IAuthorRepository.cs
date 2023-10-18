using BookStore.Core.Entities;

namespace BookStore.Core.Abstracts.Repositories
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Task<Author> FindAuthorByIdAsync(int id);
        Task<Author> FindAuthorByNameAsync(string name);

    }
}
