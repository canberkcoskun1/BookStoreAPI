using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStoreAPI.DTO;
using BookStoreAPI.DTO.User.Request;
using BookStoreAPI.DTO.User.Response;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> AddUserAsync(AddUserDto addUser)
        {
            await _userService.AddUserAsync(addUser);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> FindUserByIdAsync(int id)
        {
            var user = await _userService.FindUserByIdAsync(id);
            return Ok(CustomResponseDto.Success(user, HttpStatusCode.OK));
        }
        [HttpPut]
        public async Task<IActionResult> ActivateUserByIdAsync(int id)
        {
            await _userService.ActivateUserAsync(id);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpPut]
        public async Task<IActionResult> DeactivateUserByIdAsync(int id)
        {
            await _userService.DeactivateUserAsync(id);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var user = _userService.GetAllUsersAsync();
            return Ok(CustomResponseDto.Success(user, HttpStatusCode.OK));
        }
        [HttpPut]
        public async Task<IActionResult> MakeAdminAsync(string username)
        {
            await _userService.MakeAdminUserAsync(username);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveUserAsync(int id)
        {
            await _userService.SoftDeleteUserAsync(id);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpPut]
        public async Task<ActionResult<GetUserDto>> UpdateUserAsync(int id, UpdateUserDto updatedUser)
        {
            var user = await _userService.UpdateUserAsync(id, updatedUser);
            return Ok(CustomResponseDto.Success(user, HttpStatusCode.OK));
        }
        
        
        
    }
}
