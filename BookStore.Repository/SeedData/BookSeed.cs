using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Repository.SeedData
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            Book book1 = new() { Id = 1, BookName = "TEST1", AuthorId = 1 , GenreId = 1, Description = "Test", Title = "TEST", ISBN = 99299231};
            Book book2 = new() { Id = 2, BookName = "TEST2", AuthorId = 1 , GenreId = 2, Description = "Test", Title = "TEST", ISBN = 12312345};
            Book book3 = new() { Id = 3, BookName = "TEST3", AuthorId = 1 , GenreId = 3, Description = "Test", Title = "TEST", ISBN = 12343455};

            builder.HasData(book1, book2, book3);
        }
    }
}
