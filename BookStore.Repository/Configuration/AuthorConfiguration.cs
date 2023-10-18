using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Repository.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(50);
        }
    }
}
