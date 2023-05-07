using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class ReturnedRecordRepository : GenericRepository<ReturnedRecord>, IReturnedRecordRepository
    {
        public ReturnedRecordRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<List<ReturnedRecord>> GetReturnedRecordsWithUserIdAsync(int userId)
        {
            return await _context.ReturnedRecords.Include(r => r.User).Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<List<ReturnedRecord>> GetReturnedRecordsWithBookIdAsync(int bookId)
        {
            return await _context.ReturnedRecords.Include(r => r.Book).Where(r => r.BookId == bookId).ToListAsync();
        }
    }
}
