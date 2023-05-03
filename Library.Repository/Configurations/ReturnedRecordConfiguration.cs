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
    internal class ReturnedRecordConfiguration : IEntityTypeConfiguration<ReturnedRecord>
    {
        public void Configure(EntityTypeBuilder<ReturnedRecord> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ReturnDate).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.HasOne(x=>x.User).WithMany(x => x.ReturnedRecords).HasForeignKey(x => x.UserId);
            builder.HasOne(x=>x.Book).WithMany(x => x.ReturnedRecords).HasForeignKey(x => x.BookId);

        }
    }
}
