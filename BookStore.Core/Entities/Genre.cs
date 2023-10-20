using BookStore.Core.Common;

namespace BookStore.Core.Entities
{
    public class Genre : IBaseEntity, IDeletable
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        // Book relationships
        public virtual ICollection<Book> Books { get; set; }
    }
}
