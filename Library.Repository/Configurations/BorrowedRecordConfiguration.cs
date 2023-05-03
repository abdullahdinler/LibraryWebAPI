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
    internal class BorrowedRecordConfiguration : IEntityTypeConfiguration<BorrowedRecord>
    {
        public void Configure(EntityTypeBuilder<BorrowedRecord> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            // builder.Property(x => x.BorrowDate).IsRequired();
            // builder.Property(x => x.ReturnDate).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.User).WithMany(x => x.BorrowedRecords).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Book).WithMany(x => x.BorrowedRecords).HasForeignKey(x => x.BookId);
            
        }
    }
}
