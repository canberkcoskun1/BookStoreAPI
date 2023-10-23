using BookStoreAPI.DTO.Book.Response;
using BookStoreAPI.DTO.User.Response;

namespace BookStoreAPI.DTO.Library.Response
{
    public class GetLibraryDto
    {
        public int Id { get; set; }
        public GetUserForLibraryDto User { get; set; }
        public List<GetBooksDto> Books { get; set; }
    }
}
