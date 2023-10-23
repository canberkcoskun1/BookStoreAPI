using BookStoreAPI.DTO.Author.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.DTO.Book.Response
{
    public class GetBooksWithAuthorsDto
    {
        public string Bookname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public int EditionNumber { get; set; }
        public GetAuthorsDto Author { get; set; }

    }
}
