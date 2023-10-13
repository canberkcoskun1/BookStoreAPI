using BookStore.Core.Common;

namespace BookStore.Core.Entities
{
    public class User : IBaseEntity, IDeletable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string ProfileImg { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }

        public bool? IsAdmin { get; set; }
        public DateTime? DeletedAt { get; set; }
        // Library 1-N
        public virtual ICollection<Library> Libraries { get; set; }
        // Books N-N
        public virtual ICollection<Book> Books { get; set; }
    }
}
