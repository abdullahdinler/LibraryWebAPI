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
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(80);
            //builder.Property(x => x.Cover).IsRequired().HasMaxLength(350);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            //builder.Property(x => x.DateAdded).IsRequired();
            builder.HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);
            builder.HasOne(x=>x.Genre).WithMany(x=>x.Books).HasForeignKey(x=>x.GenreId);
        }
    }
}
