﻿using BookStoreAPI.DTO.User.Request;
using BookStoreAPI.DTO.User.Response;

namespace BookStore.Core.Abstracts.Services
{
    public interface IUserService 
    {
        Task<GetUserDto> FindUserByIdAsync(int id);
        // All User
        Task<List<GetUserDto>> GetAllUsersAsync();
        // AddUser
        Task AddUserAsync(AddUserDto addUser);
        // Activate User
        Task ActivateUserAsync(int id);
        // Deactivate User
        Task DeactivateUserAsync(int id);
        // Make Admin
        Task MakeAdminUserAsync(string username);
        
    }
}
