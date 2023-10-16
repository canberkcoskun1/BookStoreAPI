using BookStore.Core.Abstracts.Services;
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
        public async Task<IActionResult> AddUserAsync()
        {
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
        
    }
}
