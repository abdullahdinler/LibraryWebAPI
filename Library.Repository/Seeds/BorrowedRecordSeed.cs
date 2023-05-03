using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class BorrowedRecordSeed : IEntityTypeConfiguration<BorrowedRecord>
    {
        public void Configure(EntityTypeBuilder<BorrowedRecord> builder)
        {
            builder.HasData(
                new BorrowedRecord
            {
                    Id = 1,
                    BookId = 1,
                    UserId = 1,
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(15),
                    Status = "Status 1"
                    
                },
                new BorrowedRecord
                {
                    Id = 2,
                    BookId = 2,
                    UserId = 2,
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(15),
                    Status = "Status 2"
                    
                },
                new BorrowedRecord
                {
                    Id = 3,
                    BookId = 3,
                    UserId = 3,
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(15),
                    Status = "Status 3"
                    
                },
                new BorrowedRecord
                {
                    Id = 4,
                    BookId = 4,
                    UserId = 4,
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(15),
                    Status = "Status 4"
                    
                },
                new BorrowedRecord
                {
                    Id = 5,
                    BookId = 5,
                    UserId = 5,
                    BorrowDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(15),
                    Status = "Status 5"
                    
                }

            );
        }
    }
}
