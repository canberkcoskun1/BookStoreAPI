using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO.User.Request;
using Microsoft.AspNetCore.Mvc;

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
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> FindUserByIdAsync(int id)
        {
            var user = await _userService.FindUserByIdAsync(id);
            return Ok(user);
        }
        [HttpPut]
        public async Task<IActionResult> ActivateUserByIdAsync(int id)
        {
            await _userService.ActivateUserAsync(id);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> DeactivateUserByIdAsync(int id)
        {
            await _userService.DeactivateUserAsync(id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var user = _userService.GetAllUsersAsync();
            return Ok(user);
        }
        [HttpPut]
        public async Task<IActionResult> MakeAdminAsync(string username)
        {
            await _userService.MakeAdminUserAsync(username);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveUserAsync(int id)
        {
            await _userService.SoftDeleteUserAsync(id);
            return Ok();
        }
        
        
        
        
    }
}
