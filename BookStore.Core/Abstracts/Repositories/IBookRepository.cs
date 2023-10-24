using BookStore.Core.Entities;

namespace BookStore.Core.Abstracts.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<Book> FindBookByIdAsync(int id);
        Task<Book> FindBookByNameAsync(string name);
        
    }
}
