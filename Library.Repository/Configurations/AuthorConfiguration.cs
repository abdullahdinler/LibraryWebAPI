using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Configurations
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();
            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(50);
            //builder.HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);
        }
    }
}
