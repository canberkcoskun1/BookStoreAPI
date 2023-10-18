namespace BookStoreAPI.DTO.Book.Response
{
    public class GetBooksDto
    {
        public string Bookname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        // AuthorId
        public int AuthorId { get; set; }
        // GenreId
        public int GenreId { get; set; }
    }
}
