using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO;
using BookStoreAPI.DTO.Book.Request;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {   
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok(CustomResponseDto.Success(books, HttpStatusCode.OK));
        }
        [HttpPost]
        public async Task<IActionResult> AddBooksAsync(AddBooksDto addBooks)
        {
            await _bookService.AddBookAsync(addBooks);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
    }
}
