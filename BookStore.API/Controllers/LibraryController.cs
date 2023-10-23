using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetLibraryByIdAsync(int id)
        {
            var library = await _libraryService.FindLibraryByIdAsync(id);
            return Ok(CustomResponseDto.Success(library,HttpStatusCode.OK));
        }
    }
}
