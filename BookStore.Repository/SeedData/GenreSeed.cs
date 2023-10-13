using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.SeedData
{
    public class GenreSeed : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            Genre genre1 = new() { Id = 1, GenreName = "Psychology" };
            Genre genre2 = new() { Id = 2, GenreName = "Science" };
            Genre genre3 = new() { Id = 3, GenreName = "History" };

            builder.HasData(genre1, genre2, genre3);
        }
    }
}
