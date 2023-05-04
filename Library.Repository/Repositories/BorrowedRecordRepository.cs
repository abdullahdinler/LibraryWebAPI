using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;

namespace Library.Repository.Repositories
{
    public class BorrowedRecordRepository : GenericRepository<BorrowedRecord>, IBorrowedRecordRepository
    {
        public BorrowedRecordRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
