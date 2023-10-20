using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthorsAsync()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return Ok(CustomResponseDto.Success(authors, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetAuthorsByIdAsync(int id)
        {
            var author = await _authorService.GetAuthorsByIdAsync(id);
            return Ok(CustomResponseDto.Success(author, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetAuthorsByName(string name)
        {
            var author = await _authorService.GetAuthorsByNameAsync(name);
            return Ok(CustomResponseDto.Success(author, HttpStatusCode.OK));
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAuthorAsync(int id)
        {
            await _authorService.RemoveAuthorAsync(id);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
    }
}
