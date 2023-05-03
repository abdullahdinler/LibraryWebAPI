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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Address).WithMany(x => x.Users).HasForeignKey(x => x.AddressId);
            // builder.HasMany(x => x.BorrowedRecords).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            // builder.HasMany(x => x.ReturnedRecords).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}
