using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.DTO.Book.Request
{
    public class UpdateBooksDto
    {
        public string Bookname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }

    }
}
