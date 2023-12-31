﻿using BookStoreAPI.DTO.Author.Response;
using BookStoreAPI.DTO.Book.Response;

namespace BookStoreAPI.DTO.Genre.Response
{
    public class GetGenreWithBooksDto
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public List<GetBooksWithAuthorsDto> Books { get; set; }
    }
}
