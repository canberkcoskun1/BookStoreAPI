using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Repository.SeedData
{
    public class LibrarySeed : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            Library lib1 = new() { Id = 1, UserId = 1 };
            Library lib2 = new() { Id = 2, UserId = 2 };
            Library lib3 = new() { Id = 3, UserId = 3 };

            builder.HasData(lib1, lib2, lib3);
        }
    }
}
