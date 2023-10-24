using BookStore.Core.Common;

namespace BookStore.Core.Entities
{
    public class Library : IBaseEntity, IDeletable, IUpdatedAt
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get ; set; }
        // Book-Library Relationships
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
        // User-Library Relationships
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
