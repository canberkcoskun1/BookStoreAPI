using BookStore.Core.Entities;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface IUserService 
    {
        Task<GetUserDto> FindUserByIdAsync(int id);
        // Activate User
        // Deactivate User
        // Delete User
    }
}
