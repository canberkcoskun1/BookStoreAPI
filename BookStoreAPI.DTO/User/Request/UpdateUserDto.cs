namespace BookStoreAPI.DTO.User.Request
{
    public class UpdateUserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public string ProfileImg { get; set; }
    }
}
