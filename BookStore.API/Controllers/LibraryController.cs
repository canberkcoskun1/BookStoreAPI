﻿using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO;
using BookStoreAPI.DTO.Library.Request;
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
        [HttpPost]
        public async Task<IActionResult> AddLibraryByUserAsync(AddLibraryDto addLibrary)
        {
            await _libraryService.AddLibraryByUserAsync(addLibrary);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpPost]
        public async Task<IActionResult> AddBooksToLibraryAsync(int bookId, int libraryId)
        {
            await _libraryService.AddBooksToLibraryAsync(bookId, libraryId);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveLibraryAsync(int id)
        {
            await _libraryService.RemoveLibraryAsync(id);
            return Ok(CustomResponseDto.Success(null, HttpStatusCode.OK));
        }
    }
}
