using BookStore.Core.Abstracts.Services;
using BookStore.Core.Entities;
using BookStoreAPI.DTO;
using BookStoreAPI.DTO.Genre.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public async Task<IActionResult> FindGenreByIdAsync(int id)
        {
            var genre = await _genreService.FindGenreByIdAsync(id);
            return Ok(CustomResponseDto.Success(genre, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<ActionResult<GetGenreDto>> FindGenreByNameAsync(string name) 
        {
            var genre = await _genreService.FindGenreByNameAsync(name);
            return Ok(CustomResponseDto.Success(genre, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGenresAsync()
        {
            var genres = await _genreService.GetAllGenreAsync();
            return Ok(CustomResponseDto.Success(genres, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGenresWithBooksAsync()
        {
            var genres = await _genreService.GetAllGenreWithBooksAsync();
            return Ok(CustomResponseDto.Success(genres,HttpStatusCode.OK));
        }
    }
}
