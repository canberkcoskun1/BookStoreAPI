﻿using BookStore.Core.Abstracts.Services;
using BookStoreAPI.DTO;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetAuthorsByIdAsync(int id)
        {
            var author = await _authorService.GetAuthorsByIdAsync(id);
            return Ok(CustomResponseDto.Success(author, HttpStatusCode.OK));
        }
    }
}