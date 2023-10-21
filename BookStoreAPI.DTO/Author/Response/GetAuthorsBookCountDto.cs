namespace BookStoreAPI.DTO.Author.Response
{
    public class GetAuthorsBookCountDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BookCount { get; set; }
    }
}
