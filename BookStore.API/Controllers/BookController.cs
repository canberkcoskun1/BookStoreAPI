using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO;
using BookStoreAPI.DTO.Book.Request;
using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.User.Response;
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
        
        [HttpPost]
        public async Task<IActionResult> AddBooksAsync(AddBooksDto addBooks)
        {
            await _bookService.AddBookAsync(addBooks);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetBooksByNameAsync(string bookname)
        {
            var books = await _bookService.GetBookByNameAsync(bookname);
            return Ok(CustomResponseDto.Success(books, HttpStatusCode.OK));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok(CustomResponseDto.Success(books, HttpStatusCode.OK));
        }
        [HttpPut]
        public async Task<ActionResult<GetBooksDto>> UpdateBooksAsync(int id, UpdateBooksDto updateBooks)
        {
            await _bookService.UpdateBookAsync(id, updateBooks);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBooksAsync(int id)
        {
            await _bookService.RemoveBookAsync(id);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
    }
}
