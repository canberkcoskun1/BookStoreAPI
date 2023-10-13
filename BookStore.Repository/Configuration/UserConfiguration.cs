using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Username).HasMaxLength(50);
            builder.Property(x => x.EmailAdress).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(50);
            
        }
    }
}
