using BookStore.Core.Common;

namespace BookStore.Core.Entities
{
    public class Book : IBaseEntity, IDeletable
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public int EditionNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        // Author Relationships
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        // Library relationships
        public virtual ICollection<Library> Libraries { get; set; } = new HashSet<Library>();   

        // Genre relationships
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        // User Relationships
        public virtual ICollection<User> Users { get; set; }
    }
}
