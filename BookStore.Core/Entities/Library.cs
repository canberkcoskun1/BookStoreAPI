using BookStore.Core.Common;

namespace BookStore.Core.Entities
{
    public class Library : IBaseEntity
    {
        public int Id { get; set; }
        // Book-Library Relationships
        public virtual ICollection<Book> Books { get; set; }
        // User-Library Relationships
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
