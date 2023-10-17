using BookStore.Core.Entities;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Core.Abstracts.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> FindUserByIdAsync(int id);
        // Activate User
        Task<User> ActivateUserByIdAsync(int id);
        // Deactivate User
        Task<User> DeactivateUserByIdAsync(int id);
        // Make admin user
        Task<User> MakeAdminAsync(string username);
        //Task <IEnumerable<UsersWithBooksDto>> GetUsersWithBookCountAsync();

    }
}
