using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class ReturnedRecordSeed : IEntityTypeConfiguration<ReturnedRecord>
    {
        public void Configure(EntityTypeBuilder<ReturnedRecord> builder)
        {
            builder.HasData(
                new ReturnedRecord
                {
                    Id = 1,
                    BookId = 1,
                    UserId = 1,
                    ReturnDate = DateTime.Now,
                    Status = "Status 1"
                    
                },
                new ReturnedRecord
                {
                    Id = 2,
                    BookId = 2,
                    UserId = 2,
                    ReturnDate = DateTime.Now,
                    Status = "Status 2"
                    
                },
                new ReturnedRecord
                {
                    Id = 3,
                    BookId = 3,
                    UserId = 3,
                    ReturnDate = DateTime.Now,
                    Status = "Status 3"
                    
                },
                new ReturnedRecord
                {
                    Id = 4,
                    BookId = 4,
                    UserId = 4,
                    ReturnDate = DateTime.Now,
                    Status = "Status 4"
                    
                },
                new ReturnedRecord
                {
                    Id = 5,
                    BookId = 5,
                    UserId = 5,
                    ReturnDate = DateTime.Now,
                    Status = "Status 5"
                    
                }

            );
        }
    }
}
