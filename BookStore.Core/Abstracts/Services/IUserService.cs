using BookStore.Core.Entities;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface IUserService 
    {
        //All User
        Task<List<GetUserDto>> GetAllUsersAsync();
        Task<GetUserDto> FindUserByIdAsync(int id);
        // Activate User
        Task ActivateUserAsync(int id);
        // Deactivate User
        Task DeactivateUserAsync(int id);
        // Delete User
        
    }
}
