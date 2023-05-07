using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class BorrowedRecordRepository : GenericRepository<BorrowedRecord>, IBorrowedRecordRepository
    {
        public BorrowedRecordRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<List<BorrowedRecord>> GetBorrowedRecordsWithBookAsync()
        {
            return await _context.BorrowedRecords.Include(x => x.Book).ToListAsync();
        }

        public async Task<List<BorrowedRecord>> GetBorrowedRecordsWithUserIdAsync(int userId)
        {
            return await _context.BorrowedRecords.Include(x => x.Book).Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
