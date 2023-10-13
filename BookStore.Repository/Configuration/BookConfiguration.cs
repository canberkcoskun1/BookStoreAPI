using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Repository.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x =>x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x =>x.Description).IsRequired().HasMaxLength(100);
            builder.Property(x =>x.ISBN).IsRequired().HasMaxLength(100);
        }
    }
}
