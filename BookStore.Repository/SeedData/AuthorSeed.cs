using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Repository.SeedData
{
    public class AuthorSeed : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            Author author1 = new() { Id = 1, FirstName = "TEST", LastName = "TEST" };
            Author author2 = new() { Id = 2, FirstName = "TEST2", LastName = "TEST2" };
            Author author3 = new() { Id = 3, FirstName = "TEST3", LastName = "TEST3" };

            builder.HasData(author1, author2, author3);
        }
    }
}
