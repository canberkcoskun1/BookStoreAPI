using BookStore.Core.Entities;

namespace BookStore.Core.Abstracts.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> FindUserByIdAsync(int id);
        // Activate User

    }
}
