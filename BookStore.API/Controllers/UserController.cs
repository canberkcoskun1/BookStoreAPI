using BookStore.Core.Abstracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> FindUserByIdAsync(int id)
        {
            var user = await _userService.FindUserByIdAsync(id);
            return Ok(user);
        }
    }
}
