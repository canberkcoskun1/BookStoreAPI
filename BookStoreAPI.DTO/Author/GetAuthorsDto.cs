using BookStoreAPI.DTO.Book.Response;

namespace BookStoreAPI.DTO.Author
{
    public class GetAuthorsDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<GetBooksDto> Books { get; set; }
    }
}
