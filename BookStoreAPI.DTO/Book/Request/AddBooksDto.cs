namespace BookStoreAPI.DTO.Book.Request
{
    public class AddBooksDto
    {
        public string Bookname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public int EditionNumber { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
    }
}
