using BookStore.Core.Common;
using System.Reflection;

namespace BookStore.Core.Entities
{
    public class Book : IBaseEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        // Author Relationships
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        // Library relationships
        public virtual ICollection<Library> Libraries { get; set; }

        // Genre relationships
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        // User Relationships
        public virtual ICollection<User> Users { get; set; }
    }
}
